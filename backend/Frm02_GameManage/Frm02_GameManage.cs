using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatChaEntities
{
    public partial class Frm02_GameManage : Form
    {
         int imageColumnWidth;
        private bool isSearchExecuted = false;
        public Frm02_GameManage()
        {
            InitializeComponent();
            LoadData();
            LoadCategory();
        }
        void LoadData()
        {
            //LoadProduct
            this.game_Product_TotalTableAdapter1.Fill(this.catchaDataSet1.Game_Product_Total);
            this.bindingSourceG.DataSource = this.catchaDataSet1.Game_Product_Total;
            this.dataGridViewGameProducts.DataSource = this.bindingSourceG;
            //SelectionChanged
            this.dataGridViewGameProducts.SelectionChanged += dataGridViewGameProducts_SelectionChanged;
            //LoadCategoryDetail
            this.game_Product_CategoryTableAdapter1.Fill(this.catchaDataSet1.Game_Product_Category);
            this.bindingSourceC.DataSource = this.catchaDataSet1.Game_Product_Category;
            this.dataGridViewCategory.DataSource = this.bindingSourceC;
            //設定dataGridViewOrders允許拖放
            this.dataGridViewGameProducts.AllowDrop = true;
            this.dataGridViewGameProducts.DragEnter += dataGridViewOrders_DragEnter;
            this.dataGridViewGameProducts.DragDrop += dataGridViewOrders_DragDrop;
        }
        void SetImageSize()
        {
            DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dataGridViewGameProducts.Columns[5];
            imageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            imageColumnWidth = imageColumn.Width;
            imageColumn.Width = 150;
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }


        private void Frm02_GameManage_Load(object sender, EventArgs e)
        {
            SetImageSize();
        }

        catchaEntities dbContext = new catchaEntities();
        //搜尋按鈕
        private void btnSearch_Click(object sender, EventArgs e)
        {
            isSearchExecuted = true;

            var q = from p in dbContext.Game_Product_Total.AsEnumerable()
                    select  p;

            int productID;
            if (int.TryParse(txtGameProductID.Text, out productID))
            {
                q = q.Where(p => p.Product_ID == productID);
            }

            string productName = txtGameProductName.Text.Trim();
            if (!string.IsNullOrEmpty(productName))
            {
                q = q.Where(p => p.Product_Name.Contains(productName));
            }

            int productPrice;
            if (int.TryParse(txtGameProductPrice.Text, out productPrice))
            {
                q = q.Where(p => p.Product_Price == productPrice);
            }


            string remainingQuantity = txtRemainingQuantity.Text.Trim();
            if (!string.IsNullOrEmpty(remainingQuantity))
            {
                q = q.Where(p => p.Remaining_Quantity == remainingQuantity);
            }

            int selectedCategoryID;
            if (cboxCategory.SelectedItem != null && int.TryParse(cboxCategory.SelectedItem.ToString(), out selectedCategoryID))
            {
                q = q.Where(p => p.Product_Category_ID == selectedCategoryID);
            }

            bindingSourceG.DataSource = q.ToList();
            SetImageSize();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //呼叫儲存方法
            SaveChangesToDatabase();
        }

        //瀏覽圖片並插入至商品圖片欄
        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            if (isSearchExecuted)
                return;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "圖片檔案|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 獲取選擇的圖片路徑
                string imagePath = openFileDialog.FileName;

                // 在 DataGridView 中插入圖片
                DataGridViewRow selectedRow = dataGridViewGameProducts.CurrentRow;
                if (selectedRow != null)
                {
                    selectedRow.Cells["Product Image"].Value = Image.FromFile(imagePath);
                }
            }
        }
        //方法:儲存變更資料至資料庫
        //TODO:欄位空值Exception
        private void SaveChangesToDatabase()
        {
            try
            {
                bindingSourceG.EndEdit();
                // 使用 TableAdapter 更新資料庫
                int updatedRows = game_Product_TotalTableAdapter1.Update(catchaDataSet1.Game_Product_Total);

                // 檢查更新結果
                if (updatedRows > 0)
                {
                    MessageBox.Show("變更已成功儲存至資料庫。");
                }
                else
                {
                    MessageBox.Show("儲存失敗，請檢查您的變更。");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message);
            }
        }


        //拖放功能
        private void dataGridViewOrders_DragEnter(object sender, DragEventArgs e)
        {
            if (isSearchExecuted)
            {
                e.Effect = DragDropEffects.None;
                return;
            }
            e.Effect = DragDropEffects.Copy;
        }

        // 判斷拖放的檔案是圖片檔案
        private bool IsImageFile(string fileName)
        {
            string extension = Path.GetExtension(fileName);
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            return imageExtensions.Contains(extension, StringComparer.OrdinalIgnoreCase);
        }

        private void dataGridViewOrders_DragDrop(object sender, DragEventArgs e)
        {
            if (isSearchExecuted)
                return;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                string firstFile = files.FirstOrDefault();
                if (firstFile != null && IsImageFile(firstFile))
                {
                    // 取得目前選取的資料列
                    int rowIndex = dataGridViewGameProducts.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewGameProducts.Rows[rowIndex];

                    // 檢查檔案存在性
                    if (File.Exists(firstFile))
                    {
                        using (var image = Image.FromFile(firstFile))
                        {
                            selectedRow.Cells[5].Value = new Bitmap(image); // 商品圖片資料欄索引為 5
                        }
                    }
                }
            }
        }

        //載入商品類別的方法
    void LoadCategory()
        {
            List<string> categoryList = new List<string>();
            categoryList.Add(""); // 添加空白選項

            var q = from c in this.catchaDataSet1.Game_Product_Category
                    orderby c.Product_Category_ID
                    select c.Product_Category_ID.ToString(); 

            categoryList.AddRange(q);
            this.cboxCategory.Items.Clear();
            this.cboxCategory.Items.AddRange(categoryList.ToArray());
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            isSearchExecuted = false;
            ReloadDataGridView();
            SetImageSize();
        }

        private void ReloadDataGridView()
        {
            dataGridViewGameProducts.DataSource = null;
            dataGridViewGameProducts.Rows.Clear();
            dataGridViewGameProducts.Columns.Clear();
            this.game_Product_TotalTableAdapter1.Fill(this.catchaDataSet1.Game_Product_Total);
            this.bindingSourceG.DataSource = this.catchaDataSet1.Game_Product_Total;
            this.dataGridViewGameProducts.DataSource = this.bindingSourceG;
            this.game_Product_CategoryTableAdapter1.Fill(this.catchaDataSet1.Game_Product_Category);
            this.bindingSourceC.DataSource = this.catchaDataSet1.Game_Product_Category;
            this.dataGridViewCategory.DataSource = this.bindingSourceC;
        }


        private void dataGridViewGameProducts_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // 取得發生錯誤的欄位名稱
            string columnName = dataGridViewGameProducts.Columns[e.ColumnIndex].HeaderText;
            // 自訂錯誤訊息
            string errorMessage = $"欄位 {columnName} 輸入錯誤，請重新輸入正確的資料。";

            // 顯示自訂的訊息框
            MessageBox.Show(errorMessage, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // 取消預設的錯誤訊息框顯示
            e.ThrowException = false;
        }

        private void dataGridViewGameProducts_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewGameProducts.SelectedRows.Count > 0)
                {
                    int selectedCategoryID = Convert.ToInt32(dataGridViewGameProducts.CurrentRow.Cells[2].Value);
                    var q = this.catchaDataSet1.Game_Product_Category.Where(c => c.Product_Category_ID == selectedCategoryID);
                    dataGridViewCategory.DataSource = q.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
