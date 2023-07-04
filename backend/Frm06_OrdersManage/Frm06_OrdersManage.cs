using CatChaEntities.catchaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CatChaEntities
{
    public partial class Frm06_OrdersManage : Form
    {
        private bool allowEdit = true;
        public Frm06_OrdersManage()
        {
            InitializeComponent();
            LoadData();
            LoadState();
            //初始化DateTimePicker
            dtpFrom.Value = new DateTime(2000, 1, 1);
            dtpTo.Value = DateTime.Today;
        }
        catchaEntities dbContext = new catchaEntities();
        private void LoadData()
        {
            //Order Total
            this.shop_Order_Total_TableTableAdapter1.Fill(this.catchaDataSet1.Shop_Order_Total_Table);
            this.bindingSourceO.DataSource = this.catchaDataSet1.Shop_Order_Total_Table;
            this.dataGridViewOrders.DataSource = this.bindingSourceO;
            bindingNavigator1.BindingSource = bindingSourceO;
            //Order Detail
            this.shop_Order_Detail_TableTableAdapter1.Fill(this.catchaDataSet1.Shop_Order_Detail_Table);
            this.bindingSourceOD.DataSource = this.catchaDataSet1.Shop_Order_Detail_Table;
            this.dataGridViewOrderDetail.DataSource = this.bindingSourceOD;
            //SelectionChanged
            this.dataGridViewOrders.SelectionChanged += dataGridViewOrders_SelectionChanged;
        }

        private void LoadState()
        {
            List<string> stateList = new List<string>();
            stateList.Add(""); // 添加空白選項

            var q = from c in dbContext.Shop_Return_Status_Data_Table
                    orderby c.Processing_Status_ID
                    select c.Processing_Status_ID.ToString();
            stateList.AddRange(q);
            this.cboxState.Items.Clear();
            this.cboxState.Items.AddRange(stateList.ToArray());
        }

        private void ReloadDataGridView()
        {
            dataGridViewOrders.DataSource = null;
            dataGridViewOrders.Rows.Clear();
            dataGridViewOrders.Columns.Clear();
            this.shop_Order_Total_TableTableAdapter1.Fill(this.catchaDataSet1.Shop_Order_Total_Table);
            this.bindingSourceO.DataSource = this.catchaDataSet1.Shop_Order_Total_Table;
            this.dataGridViewOrders.DataSource = this.bindingSourceO;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var q = from p in dbContext.Shop_Order_Total_Table
                        select p;

                int orderID;
                if (int.TryParse(txtOrderID.Text, out orderID))
                {
                    q = q.Where(p => p.Order_ID == orderID);
                }

                int memberID;
                if (int.TryParse(txtMemberID.Text, out memberID))
                {
                    q = q.Where(p => p.Member_ID == memberID);
                }

                DateTime creationTimeFrom = dtpFrom.Value.Date;
                DateTime creationTimeTo = dtpTo.Value.Date.AddDays(1).AddTicks(-1);
                q = q.Where(p => p.Order_Creation_Date >= creationTimeFrom && p.Order_Creation_Date <= creationTimeTo);

                bindingSourceO.DataSource = q.ToList();
                allowEdit = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ReloadDataGridView();
            allowEdit = true;
        }

        private void dataGridViewOrders_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // 取得發生錯誤的欄位名稱
            string columnName = dataGridViewOrders.Columns[e.ColumnIndex].HeaderText;
            // 自訂錯誤訊息
            string errorMessage = $"欄位 {columnName} 輸入錯誤，請重新輸入正確的資料。";

            // 顯示自訂的訊息框
            MessageBox.Show(errorMessage, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // 取消預設的錯誤訊息框顯示
            e.ThrowException = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (allowEdit && dataGridViewOrders.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewOrders.SelectedRows[0];
                int OD_MemberID = (int)selectedRow.Cells["Member ID"].Value;
                int OD_OrderID = (int)selectedRow.Cells["Order ID"].Value;
                DateTime OD_Order_Creation_Date = (DateTime)selectedRow.Cells["Order Creation Date"].Value;
                DateTime OD_Last_Update_Time = (DateTime)selectedRow.Cells["Last Update Time"].Value;
                int OD_AddressID = (int)selectedRow.Cells["Address ID"].Value;
                int OD_Order_Status_ID = (int)selectedRow.Cells["Order Status ID"].Value;
                int OD_Payment_Method_ID = (int)selectedRow.Cells["Payment Method ID"].Value;
                int Coupon_ID = (int)selectedRow.Cells["Payment Method ID"].Value;

                Frm06_OrdersManage_Edit frm = new Frm06_OrdersManage_Edit
                {
                    MemberID = OD_MemberID,
                    OrderID = OD_OrderID,
                    OrderCreationDate = OD_Order_Creation_Date,
                    LastUpdateTime = OD_Last_Update_Time,
                    AddressID = OD_AddressID,
                    OrderStatusID = OD_Order_Status_ID,
                    PaymentMethodID = OD_Payment_Method_ID,
                    CouponID = Coupon_ID
                };
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    try
                    {
                        Shop_Order_Total_Table modifiedOrder = frm.ModifiedOrder;
                        int rowIndex = dataGridViewOrders.SelectedRows[0].Index;
                        DataRowView selectedRowView = (DataRowView)dataGridViewOrders.SelectedRows[0].DataBoundItem;
                        DataRow selectedDataRow = selectedRowView.Row;

                        Shop_Order_Total_Table selectedOrder = dbContext.Shop_Order_Total_Table.Find(selectedDataRow["Order ID"]);

                        selectedOrder.Member_ID = modifiedOrder.Member_ID;
                        selectedOrder.Order_ID = modifiedOrder.Order_ID;
                        selectedOrder.Order_Creation_Date = modifiedOrder.Order_Creation_Date;
                        selectedOrder.Last_Update_Time = modifiedOrder.Last_Update_Time;
                        selectedOrder.Address_ID = modifiedOrder.Address_ID;
                        selectedOrder.Order_Status_ID = modifiedOrder.Order_Status_ID;
                        selectedOrder.Payment_Method_ID = modifiedOrder.Payment_Method_ID;
                        selectedOrder.Coupon_ID = modifiedOrder.Coupon_ID;
                        int updatedRows = dbContext.SaveChanges();

                        // 檢查更新結果
                        if (updatedRows > 0)
                        {
                            MessageBox.Show("變更已成功儲存至資料庫。");
                            ReloadDataGridView();
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
                else if (frm.DialogResult == DialogResult.Cancel)
                {
                    MessageBox.Show("取消編輯資料");
                }

            }
        }

        private void dataGridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewOrders.SelectedRows.Count > 0)
                {
                    int selectedOrderId = Convert.ToInt32(dataGridViewOrders.CurrentRow.Cells[0].Value);
                    var q = this.catchaDataSet1.Shop_Order_Detail_Table.Where(od => od.Order_ID == selectedOrderId);
                    dataGridViewOrderDetail.DataSource = q.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int updatedRows = dbContext.SaveChanges();

            // 檢查更新結果
            if (updatedRows > 0)
            {
                MessageBox.Show("變更已成功儲存至資料庫。");
                ReloadDataGridView();
            }
            else
            {
                MessageBox.Show("儲存失敗，請檢查您的變更。");
            }
        }
    }
}
