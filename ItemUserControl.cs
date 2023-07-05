using CatCaha.NewFolder1;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;

namespace CatCha
{
    public partial class ItemUserControl : UserControl
    {
        public ItemUserControl()
        {
            InitializeComponent();
                 
        }
        public delegate void QuantityChangedEventHandler(int newQuantity);
        public event QuantityChangedEventHandler QuantityChanged;
        project123Entities dbContext = new project123Entities();
        public Image ItemImage
        {
            get { return picBoxItem.Image; }
            set { picBoxItem.Image=value; }
        }

        public string ItemName
        {
            get { return labItemName.Text; }
            set { labItemName.Text = value; }
        }

        public decimal ItemPrice
        {
            get { return decimal.Parse(labItemPrice.Text); }
            set { labItemPrice.Text = value.ToString(); }
        }
        public decimal ItemTotalPrice
        {
            get { return decimal.Parse(labTotalPrice.Text); }
            set { labTotalPrice.Text = value.ToString(); }
        }
        public decimal ItemProductID
        {
            get;
            set;
        }

        public int ItemCount
        {
            get { return count; }
            set { count = value; labCount.Text = value.ToString(); }
        }
        public int OrderID
        {
            get;
            set;
        }
        
        public int getTotalPrice()
        {

            return (int)Convert.ToDecimal(labTotalPrice.Text);
        }
        int count = 1;
        private void btnAdd_Click(object sender, EventArgs e)
        {
       
            count++;
            labCount.Text = count.ToString();
            labTotalPrice.Text = $"{Convert.ToDecimal(labItemPrice.Text) * count}";

            QuantityChanged?.Invoke(count);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (count > 1)
            {
                count--;
                labCount.Text = count.ToString();

                int sub = 0;
                sub++;
                labTotalPrice.Text = $"{Convert.ToDecimal(labTotalPrice.Text) - Convert.ToDecimal(labItemPrice.Text) * sub}";

                //如果 QuantityChanged 不是 null，則執行 Invoke(count)，否則不執行任何操作。
                QuantityChanged?.Invoke(count);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            var flowLayoutPanel = Parent as FlowLayoutPanel;
            if (flowLayoutPanel != null)
            {
                flowLayoutPanel.Controls.Remove(this);
            }

            // 刪除資料庫中的商品訂單詳細資料
            var product = dbContext.Shop_Order_Detail_Table.FirstOrDefault(p => p.Product_ID == ItemProductID && p.Order_ID == OrderID);
            if (product != null)
            {
                dbContext.Shop_Order_Detail_Table.Remove(product);
                dbContext.SaveChanges();
            }
            QuantityChanged?.Invoke(count);
        }

    }
}
