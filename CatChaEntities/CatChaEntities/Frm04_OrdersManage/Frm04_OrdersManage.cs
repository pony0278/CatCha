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
    public partial class Frm04_OrdersManage : Form
    {
        public Frm04_OrdersManage()
        {
            InitializeComponent();
            LoadData();
            LoadState();
            //初始化DateTimePicker
            dtpFrom.Value = new DateTime(2000, 1, 1);
            dtpTo.Value = DateTime.Today;
        }
        catchaEntities dbContext = new catchaEntities();

        //載入DataBase
        private void LoadData()
        {
            // Order Total
            var orderTotals = dbContext.Shop_Order_Total_Table.ToList();
            bindingSourceO.DataSource = orderTotals;
            dataGridViewOrders.DataSource = bindingSourceO;
            // Order Detail
            var orderDetails = dbContext.Shop_Order_Detail_Table.ToList();
            bindingSourceOD.DataSource = orderDetails;
            //SelectionChanged
            this.dataGridViewOrders.SelectionChanged += dataGridViewOrders_SelectionChanged;
        }

        //載入訂單狀態Combox的Item
        private void LoadState()
        {
            List<string> stateList = new List<string>();
            stateList.Add("");

            var q = from c in dbContext.Shop_Return_Status_Data_Table
                    orderby c.Processing_Status_ID
                    select c.Processing_Status_ID.ToString();
            stateList.AddRange(q);
            this.cboxState.Items.Clear();
            this.cboxState.Items.AddRange(stateList.ToArray());
        }

        //重新整理頁面
        private void ReloadDataGridView()
        {
            dataGridViewOrders.DataSource = null;
            dataGridViewOrders.Rows.Clear();
            dataGridViewOrders.Columns.Clear();
            var orderTotals = dbContext.Shop_Order_Total_Table.ToList();
            bindingSourceO.DataSource = orderTotals;
            dataGridViewOrders.DataSource = bindingSourceO;
        }

        //搜尋按鈕
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //新增按鈕
        private void btnADD_Click(object sender, EventArgs e)
        {
            Frm04_OrdersManage_ADD frm = new Frm04_OrdersManage_ADD();
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    Shop_Order_Total_Table newOrder = frm.NewOrder;
                    dbContext.Shop_Order_Total_Table.Add(newOrder);
                    dbContext.SaveChanges();

                    ReloadDataGridView();

                    MessageBox.Show("變更已成功儲存至資料庫。");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (frm.DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("取消編輯資料");
            }
        }

        //編輯按鈕
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewOrders.SelectedRows[0];
                int MemberID = (int)selectedRow.Cells["Member_ID"].Value;
                int OrderID = (int)selectedRow.Cells["Order_ID"].Value;
                DateTime Order_Creation_Date = (DateTime)selectedRow.Cells["Order_Creation_Date"].Value;
                DateTime Last_Update_Time = (DateTime)selectedRow.Cells["Last_Update_Time"].Value;
                int AddressID = (int)selectedRow.Cells["Address_ID"].Value;
                int Order_Status_ID = (int)selectedRow.Cells["Order_Status_ID"].Value;
                int Payment_Method_ID = (int)selectedRow.Cells["Payment_Method_ID"].Value;
                int Coupon_ID = (int)selectedRow.Cells["Coupon_ID"].Value;
                string Recipient_Address = selectedRow.Cells["Recipient_Address"].Value.ToString();
                string Recipient_Name = selectedRow.Cells["Recipient_Name"].Value.ToString();
                string Recipient_Phone = selectedRow.Cells["Recipient_Phone"].Value.ToString();

                Frm04_OrdersManage_Edit frm = new Frm04_OrdersManage_Edit
                {
                    MemberID = MemberID,
                    OrderID = OrderID,
                    OrderCreationDate = Order_Creation_Date,
                    LastUpdateTime = Last_Update_Time,
                    AddressID = AddressID,
                    OrderStatusID = Order_Status_ID,
                    PaymentMethodID = Payment_Method_ID,
                    CouponID = Coupon_ID,
                    RecipientAddress = Recipient_Address,
                    RecipientName = Recipient_Name,
                    RecipientPhone = Recipient_Phone
                };
                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    try
                    {
                        Shop_Order_Total_Table modifiedOrder = frm.ModifiedOrder;
                        int selectedRowIndex = dataGridViewOrders.SelectedRows[0].Index;
                        DataGridViewRow dgRow = dataGridViewOrders.Rows[selectedRowIndex];
                        int selectedOrderID = (int)dgRow.Cells["Order_ID"].Value;

                        Shop_Order_Total_Table selectedOrder = dbContext.Shop_Order_Total_Table.Find(selectedOrderID);

                        selectedOrder.Member_ID = modifiedOrder.Member_ID;
                        selectedOrder.Order_ID = modifiedOrder.Order_ID;
                        selectedOrder.Order_Creation_Date = modifiedOrder.Order_Creation_Date;
                        selectedOrder.Last_Update_Time = modifiedOrder.Last_Update_Time;
                        selectedOrder.Address_ID = modifiedOrder.Address_ID;
                        selectedOrder.Order_Status_ID = modifiedOrder.Order_Status_ID;
                        selectedOrder.Payment_Method_ID = modifiedOrder.Payment_Method_ID;
                        selectedOrder.Coupon_ID = modifiedOrder.Coupon_ID;
                        selectedOrder.Recipient_Address = modifiedOrder.Recipient_Address;
                        selectedOrder.Recipient_Name = modifiedOrder.Recipient_Name;
                        selectedOrder.Recipient_Phone = modifiedOrder.Recipient_Phone;
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

        //刪除按鈕
        //因OrderDetail關聯表格，無法刪除OrderTotal的資料，故先不顯示該功能
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridViewOrders.SelectedRows[0];
                    int orderID = (int)selectedRow.Cells["Order_ID"].Value;
                    Shop_Order_Total_Table orderToDelete = dbContext.Shop_Order_Total_Table.Find(orderID);

                    DialogResult result = MessageBox.Show("確定要刪除選取的資料行嗎？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        dbContext.Shop_Order_Total_Table.Remove(orderToDelete);
                        int deletedRows = dbContext.SaveChanges();

                        if (deletedRows > 0)
                        {
                            MessageBox.Show("資料行已成功刪除。");
                            ReloadDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("刪除失敗，請檢查您的操作。");
                        }
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


        //設定選取資料行顯示對應的明細表單
        private void dataGridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewOrders.SelectedRows.Count > 0)
                {
                    int selectedOrderId = Convert.ToInt32(dataGridViewOrders.CurrentRow.Cells[0].Value);
                    var q = this.dbContext.Shop_Order_Detail_Table.Where(od => od.Order_ID == selectedOrderId);
                    dataGridViewOrderDetail.DataSource = q.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //設定dataGridViewOrders的錯誤訊息
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

        //右鍵刪除功能
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (dataGridViewOrders.SelectedRows.Count > 0)
                {
                    try
                    {
                        DataGridViewRow selectedRow = dataGridViewOrders.SelectedRows[0];
                        int orderID = (int)selectedRow.Cells["Order_ID"].Value;
                        Shop_Order_Total_Table orderToDelete = dbContext.Shop_Order_Total_Table.Find(orderID);

                        DialogResult result = MessageBox.Show("確定要刪除選取的資料行嗎？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            dbContext.Shop_Order_Total_Table.Remove(orderToDelete);
                            int deletedRows = dbContext.SaveChanges();

                            if (deletedRows > 0)
                            {
                                MessageBox.Show("資料行已成功刪除。");
                                ReloadDataGridView();
                            }
                            else
                            {
                                MessageBox.Show("刪除失敗，請檢查您的操作。");
                            }
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
}
