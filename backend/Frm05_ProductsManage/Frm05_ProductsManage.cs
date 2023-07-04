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
    public partial class Frm05_ProductsManage : Form
    {
        public Frm05_ProductsManage()
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
            this.shop_Product_TotalTableAdapter1.Fill(this.catchaDataSet1.Shop_Product_Total);
            this.shop_Product_Image_TableTableAdapter1.Fill(this.catchaDataSet1.Shop_Product_Image_Table);
            this.bindingSourceP.DataSource = this.catchaDataSet1.Shop_Product_Total;
            this.dataGridViewProducts.DataSource = this.bindingSourceP;
        }

        catchaEntities dbContext = new catchaEntities();
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
                        //select new
                        //{
                        //    ProductName = p.Product_Name,
                        //    ProductID = p.Product_ID,
                        //    ProductCategoryID = p.Product_Category_ID,
                        //    ProductDescription = p.Product_Description,
                        //    ProductPrice = p.Product_Price,
                        //    ProductSize = p.Size,
                        //    ProductWeight = p.Weight,
                        //    ReleaseDate = p.Release_Date,
                        //    ProductDiscontinued = p.Discontinued,
                        //    RemainingQuantity = p.Remaining_Quantity,
                        //    SupplierID = p.Supplier_ID
                        //};

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


                //if (cboxProductState.SelectedItem != null && cboxProductState.SelectedItem.ToString() == "已停售")
                //{
                //    bool discontinued = true;
                //    q = q.Where(p => p.Product_Description == discontinued);
                //}
                //else if (cboxProductState.SelectedItem != null && cboxProductState.SelectedItem.ToString() == "銷售中")
                //{
                //    bool discontinued = false;
                //    q = q.Where(p => p.Product_Description == discontinued);
                //}



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
                bindingSourceP.EndEdit();

                // 檢查必填欄位是否為空值
                //foreach (DataRow row in catchaDataSet1.Shop_Product_Total.Rows)
                //{
                //    foreach (var item in row.ItemArray)
                //    {
                //        if (item == DBNull.Value)
                //        {
                //            MessageBox.Show("必填欄位不能為空值。");
                //            return; // 停止執行儲存動作
                //        }
                //    }
                //}

                // 使用 TableAdapter 更新資料庫
                int updatedRows = shop_Product_TotalTableAdapter1.Update(catchaDataSet1.Shop_Product_Total);

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

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
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
    }
}
