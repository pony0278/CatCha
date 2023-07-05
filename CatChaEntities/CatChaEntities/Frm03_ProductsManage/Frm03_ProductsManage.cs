using CatChaEntities.catchaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatChaEntities
{
    public partial class Frm03_ProductsManage : Form
    {

        int imageColumnWidth;
        catchaEntities dbContext = new catchaEntities();
        public Frm03_ProductsManage()
        {
            InitializeComponent();
            LoadData();
            LoadCategory();
            LoadState();
            //初始化DateTimePicker
            dtpFrom.Value = new DateTime(2000, 1, 1);
            dtpTo.Value = DateTime.Today;
        }
        void LoadData()
        {
            // Load Product data
            var products = dbContext.Shop_Product_Total.ToList();
            bindingSourceP.DataSource = products;
            dataGridViewProducts.DataSource = bindingSourceP;
            // Load Product Image data
            var productImages = dbContext.Shop_Product_Image_Table.ToList();
            bindingSourcePic.DataSource = productImages;
            dataGridViewPicture.DataSource = bindingSourcePic;
            // Load Product Category data
            var productCategories = dbContext.Shop_Product_Category.ToList();
            bindingSourceC.DataSource = productCategories;
            dataGridViewCategory.DataSource = bindingSourceC;
            //select change
            this.dataGridViewProducts.SelectionChanged += this.dataGridViewProducts_SelectionChanged;
            SetImageSize();
        }

        void SetImageSize()
        {
            DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dataGridViewPicture.Columns[1];
            imageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            imageColumnWidth = imageColumn.Width;
            imageColumn.Width = 150;
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }


        void LoadCategory()
        {
            List<string> categoryList = new List<string>();
            categoryList.Add(""); // 添加空白選項

            var q = from c in this.dbContext.Shop_Product_Category
                          orderby c.Product_Category_ID
                          select c.Product_Category_ID.ToString();
            categoryList.AddRange(q);
            this.cboxCategory.Items.Clear();
            this.cboxCategory.Items.AddRange(categoryList.ToArray());
        }

        void LoadState()
        {
            List<string> categoryList = new List<string>();
            categoryList.Add(""); // 添加空白選項
            categoryList.Add("已停售");
            categoryList.Add("銷售中");

            cboxProductState.Items.Clear();
            cboxProductState.Items.AddRange(categoryList.ToArray());
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var q = from p in dbContext.Shop_Product_Total
                        select p;   

                int productID;
                if (int.TryParse(txtProductID.Text, out productID))
                {
                    q = q.Where(p => p.Product_ID == productID);
                }

                string name = txtProductName.Text.Trim();
                if (!string.IsNullOrEmpty(name))
                {
                    q = q.Where(p => p.Product_Name.Contains(name));
                }

                int price;
                if (int.TryParse(txtProductPrice.Text, out price))
                {
                    q = q.Where(p => p.Product_Price == price);
                }

                int selectedCategory;
                if (cboxCategory.SelectedItem != null && int.TryParse(cboxCategory.SelectedItem.ToString(), out selectedCategory))
                {
                    q = q.Where(p => p.Product_Category_ID == selectedCategory);
                }


                if (cboxProductState.SelectedItem != null && cboxProductState.SelectedItem.ToString() == "已停售")
                {
                    bool discontinued = true;
                    q = q.Where(p => p.Discontinued == discontinued);
                }
                else if (cboxProductState.SelectedItem != null && cboxProductState.SelectedItem.ToString() == "銷售中")
                {
                    bool discontinued = false;
                    q = q.Where(p => p.Discontinued == discontinued);
                }

                DateTime releaseDateFrom = dtpFrom.Value.Date;
                DateTime releaseDateTo = dtpTo.Value.Date.AddDays(1).AddTicks(-1);
                if (releaseDateFrom != DateTime.MinValue)
                {
                    q = q.Where(p => p.Release_Date >= releaseDateFrom);
                }
                if (releaseDateTo != DateTime.MaxValue)
                {
                    q = q.Where(p => p.Release_Date <= releaseDateTo);
                }


                int remainingQuantity;
                if (int.TryParse(txtRemainingQuantity.Text, out remainingQuantity))
                {
                    q = q.Where(p => p.Remaining_Quantity == remainingQuantity);
                }


                bindingSourceP.DataSource = q.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChangesToDatabase();
        }

        private void SaveChangesToDatabase()
        {
            try
            {
                // 確定 bindingSource1 的資料來源是 DataSet 中的 "Game_Product_Total"
                bindingSourceC.EndEdit();
                bindingSourceP.EndEdit();
                bindingSourcePic.EndEdit();

                // 使用 TableAdapter 更新資料庫
                int updatedRowsP = dbContext.SaveChanges();
                int updatedRowsC = dbContext.SaveChanges();
                int updatedRowsPic = dbContext.SaveChanges();

                // 檢查更新結果
                if (updatedRowsP > 0 || updatedRowsC >0 || updatedRowsPic>0)
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

        private void dataGridViewProducts_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // 取得發生錯誤的欄位名稱
            string columnName = dataGridViewProducts.Columns[e.ColumnIndex].HeaderText;
            // 檢查資料格的值是否為 DBNull
            object cellValue = dataGridViewProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            if (cellValue == DBNull.Value)
            {
                cellValue = "";
            }

            // 自訂錯誤訊息
            string errorMessage = $"欄位 {columnName} 輸入錯誤，請重新輸入正確的資料。";

            // 顯示自訂的訊息框
            MessageBox.Show(errorMessage, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // 取消預設的錯誤訊息框顯示
            e.ThrowException = false;
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProducts.SelectedRows.Count > 0)
                {
                    int selectedCategoryID = Convert.ToInt32(dataGridViewProducts.CurrentRow.Cells[2].Value);
                    var q1 = this.dbContext.Shop_Product_Category.Where(c => c.Product_Category_ID == selectedCategoryID);
                    dataGridViewCategory.DataSource = q1.ToList();
                    int selectedPictureID = Convert.ToInt32(dataGridViewProducts.CurrentRow.Cells[1].Value);
                    var q2 = this.dbContext.Shop_Product_Image_Table.Where(pic =>pic.Product_Image_ID  == selectedPictureID);
                    dataGridViewPicture.DataSource = q2.ToList();
                    SetImageSize();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
