using System;
using System.Drawing;
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

        public decimal ItemCount
        {
            get;
            set;
        }
        public string example
        { get; set; }
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
            var flowLayoutpanel1=Parent as FlowLayoutPanel;
            if (flowLayoutpanel1 != null )
            {
                flowLayoutpanel1.Controls.Remove(this);
            }
            QuantityChanged?.Invoke(count);
        }

    }
}
