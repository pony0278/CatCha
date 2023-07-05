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
    public partial class Frm01_GameManage : Form
    {
         int imageColumnWidth;
         catchaEntities dbContext = new catchaEntities();
        public Frm01_GameManage()
        {
            InitializeComponent();
            LoadData();
            LoadCategory();
            SetImageSize();
        }

        //載入DataBase
        void LoadData()
        {
            // LoadProduct
            var gameProducts = dbContext.Game_Product_Total.ToList();
            bindingSourceG.DataSource = gameProducts;
            this.dataGridViewGameProducts.DataSource = bindingSourceG;
            // SelectionChanged
            this.dataGridViewGameProducts.SelectionChanged += dataGridViewGameProducts_SelectionChanged;
            // LoadCategoryDetail
            var categories = dbContext.Game_Product_Category.ToList();
            this.bindingSourceC.DataSource = categories;
            //設定dataGridViewOrders允許拖放
            this.dataGridViewGameProducts.AllowDrop = true;
            this.dataGridViewGameProducts.DragEnter += dataGridViewOrders_DragEnter;
            this.dataGridViewGameProducts.DragDrop += dataGridViewOrders_DragDrop;
        }

        //設定圖片欄位的大小
        void SetImageSize()
        {
            DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dataGridViewGameProducts.Columns[5];
            imageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            imageColumnWidth = imageColumn.Width;
            imageColumn.Width = 150;
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        //載入商品類別的方法
        void LoadCategory()
        {
            List<string> categoryList = new List<string>();
            categoryList.Add(""); // 添加空白選項

            var q = from c in dbContext.Game_Product_Category
                    orderby c.Product_Category_ID
                    select c.Product_Category_ID.ToString();

            categoryList.AddRange(q);
            this.cboxCategory.Items.Clear();
            this.cboxCategory.Items.AddRange(categoryList.ToArray());
        }

        //搜尋按鈕
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var q = from p in dbContext.Game_Product_Total
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

            if (cboxCategory.SelectedItem != null)
            {
                string selectedCategoryID = cboxCategory.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(selectedCategoryID))
                {
                    q = q.Where(p => p.Product_Category_ID.ToString() == selectedCategoryID);
                }
            }

            bindingSourceG.DataSource = q.ToList();
            SetImageSize();
        }

        //儲存按鈕
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var newGameProducts = bindingSourceG.DataSource as List<Game_Product_Total>;
                if (newGameProducts != null)
                {
                    foreach (var product in newGameProducts)
                    {
                        if (product.Product_ID == 0)
                        {
                            dbContext.Game_Product_Total.Add(product);
                        }
                    }
                }

                var newGameCategory = bindingSourceC.DataSource as List<Game_Product_Category>;
                if (newGameCategory != null)
                {
                    foreach (var category in newGameCategory)
                    {
                        if (category.Product_Category_ID == 0)
                        {
                            dbContext.Game_Product_Category.Add(category);
                        }
                    }
                }

                int updatedRows = dbContext.SaveChanges();

                // 檢查更新結果
                if (updatedRows > 0)
                {
                    MessageBox.Show("變更已成功儲存至資料庫。");
                    LoadData();
                    SetImageSize();
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

        //瀏覽圖片並插入至商品圖片欄
        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
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
                    int columnIndex = selectedRow.Cells["Product_Image"].ColumnIndex;
                    selectedRow.Cells[columnIndex].Value = Image.FromFile(imagePath);
                }
            }
        }

        //拖放功能
        private void dataGridViewOrders_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        // 判斷拖放的檔案是圖片檔案
        private bool IsImageFile(string fileName)
        {
            string extension = Path.GetExtension(fileName);
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            return imageExtensions.Contains(extension, StringComparer.OrdinalIgnoreCase);
        }

        //拖放功能
        private void dataGridViewOrders_DragDrop(object sender, DragEventArgs e)
        {
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

        //設定dataGridViewGameProducts選取欄位時，在dataGridViewCategory顯示對應類別ID的商品類別資料
        private void dataGridViewGameProducts_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewGameProducts.SelectedRows.Count > 0)
                {
                    int selectedCategoryID = Convert.ToInt32(dataGridViewGameProducts.CurrentRow.Cells[2].Value);
                    var q = dbContext.Game_Product_Category.Where(c => c.Product_Category_ID == selectedCategoryID).ToList();
                    dataGridViewCategory.DataSource = q;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //設定DataGridView編輯時產生的DataError訊息方塊
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


        private void dataGridViewCategory_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // 取得發生錯誤的欄位名稱
            string columnName = dataGridViewCategory.Columns[e.ColumnIndex].HeaderText;
            // 自訂錯誤訊息
            string errorMessage = $"欄位 {columnName} 輸入錯誤，請重新輸入正確的資料。";

            // 顯示自訂的訊息框
            MessageBox.Show(errorMessage, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // 取消預設的錯誤訊息框顯示
            e.ThrowException = false;
        }

        //dataGridViewGameProducts的右鍵刪除功能
        private void toolStripDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewGameProducts.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridViewGameProducts.SelectedRows[0];
                    if (selectedRow.Cells["Product_ID"].Value != null)
                    {
                        int productID = (int)selectedRow.Cells["Product_ID"].Value;
                        Game_Product_Total productToDelete = dbContext.Game_Product_Total.Find(productID);

                        DialogResult result = MessageBox.Show("確定要刪除選取的資料行嗎？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            dbContext.Game_Product_Total.Remove(productToDelete);
                            int deletedRows = dbContext.SaveChanges();

                            if (deletedRows > 0)
                            {
                                MessageBox.Show("資料行已成功刪除。");
                                LoadData();
                                SetImageSize();
                            }
                            else
                            {
                                MessageBox.Show("刪除失敗，請檢查您的操作。");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("選取的資料行無效，請重新選取。");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("發生錯誤: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("請先選取要刪除的資料行。");
            }
        }
    }
}
