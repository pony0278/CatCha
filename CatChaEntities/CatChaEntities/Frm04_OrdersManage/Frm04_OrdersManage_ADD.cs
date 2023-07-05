using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CatChaEntities
{
    public partial class Frm04_OrdersManage_ADD : Form
    {
        catchaEntities dbContext = new catchaEntities();
        public Frm04_OrdersManage_ADD()
        {
            InitializeComponent();
            //初始化DateTimePicker
            dtpOrder_Creation_Time.Value = DateTime.Today;
            dtpLast_Update_Time.Value = DateTime.Today;
        }

        private void shop_Order_Total_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shop_Order_Total_TableBindingSource.EndEdit();
            dbContext.SaveChanges();
        }
        public int MemberID
        {
            get { return int.Parse(txtMember_ID.Text); }
        }

        public DateTime OrderCreationDate
        {
            get { return DateTime.Parse(dtpOrder_Creation_Time.Text); }
        }

        public DateTime LastUpdateTime
        {
            get { return DateTime.Parse(dtpLast_Update_Time.Text); }
        }

        public int AddressID
        {
            get { return int.Parse(txtAddress_ID.Text); }
        }

        public int OrderStatusID
        {
            get { return int.Parse(txtOrder_Status_ID.Text); }
        }

        public int PaymentMethodID
        {
            get { return int.Parse(txtPayment_Method_ID.Text); }
        }

        public int CouponID
        {
            get { return int.Parse(txtCoupon_ID.Text); }
        }

        public string RecipientAddress
        {
            get { return txtRecipientAddress.Text; }
        }

        public string RecipientName
        {
            get { return txtRecipientName.Text; }
        }

        public string RecipientPhone
        {
            get { return txtRecipientPhone.Text; }
        }

        public Shop_Order_Total_Table NewOrder { get;  set; }

        private void txtUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Shop_Order_Total_Table newOrder = new Shop_Order_Total_Table
                {
                    Member_ID = MemberID,
                    Order_Creation_Date = OrderCreationDate,
                    Last_Update_Time = LastUpdateTime,
                    Address_ID = AddressID,
                    Order_Status_ID = OrderStatusID,
                    Payment_Method_ID = PaymentMethodID,
                    Coupon_ID = CouponID,
                    Recipient_Address = RecipientAddress,
                    Recipient_Name = RecipientName,
                    Recipient_Phone = RecipientPhone
                };

                NewOrder = newOrder;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
