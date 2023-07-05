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
    public partial class Frm04_OrdersManage_Edit : Form
    {
        catchaEntities dbContext  = new catchaEntities();
        public Frm04_OrdersManage_Edit()
        {
            InitializeComponent();
            //初始化DateTimePicker
            dtpOrder_Creation_Time.Value = new DateTime(2000, 1, 1);
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
            set { txtMember_ID.Text = value.ToString(); }
        }

        public int OrderID
        {
            get { return int.Parse(txtOrder_ID.Text); }
            set { txtOrder_ID.Text = value.ToString(); }
        }

        public DateTime OrderCreationDate
        {
            get { return DateTime.Parse(dtpOrder_Creation_Time.Text); }
            set { dtpOrder_Creation_Time.Text = value.ToString(); }
        }

        public DateTime LastUpdateTime
        {
            get { return DateTime.Parse(dtpLast_Update_Time.Text); }
            set { dtpLast_Update_Time.Text = value.ToString(); }
        }

        public int AddressID
        {
            get { return int.Parse(txtAddress_ID.Text); }
            set { txtAddress_ID.Text = value.ToString(); }
        }

        public int OrderStatusID
        {
            get { return int.Parse(txtOrder_Status_ID.Text); }
            set { txtOrder_Status_ID.Text = value.ToString(); }
        }

        public int PaymentMethodID
        {
            get { return int.Parse(txtPayment_Method_ID.Text); }
            set { txtPayment_Method_ID.Text = value.ToString(); }
        }

        public int CouponID
        {
            get { return int.Parse(txtCoupon_ID.Text); }
            set { txtCoupon_ID.Text = value.ToString(); }
        }

        public string RecipientAddress
        {
            get { return txtRecipientAddress.Text; }
            set { txtRecipientAddress.Text = value; }
        }

        public string RecipientName
        {
            get { return txtRecipientName.Text; }
            set { txtRecipientName.Text = value; }
        }

        public string RecipientPhone
        {
            get { return txtRecipientPhone.Text; }
            set { txtRecipientPhone.Text = value; }
        }

        public Shop_Order_Total_Table ModifiedOrder { get;  set; }

        private void txtUpdate_Click(object sender, EventArgs e)
        {
            ModifiedOrder = new Shop_Order_Total_Table
            {
                Member_ID = MemberID,
                Order_ID = OrderID,
                Order_Creation_Date = OrderCreationDate,
                Last_Update_Time = LastUpdateTime,
                Address_ID = AddressID,
                Order_Status_ID = OrderStatusID,
                Payment_Method_ID = PaymentMethodID,
                Coupon_ID = CouponID,
                Recipient_Address = RecipientAddress,
                Recipient_Name = RecipientName,
                Recipient_Phone = RecipientPhone,
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
