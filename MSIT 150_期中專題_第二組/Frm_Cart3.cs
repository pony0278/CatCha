using Cart2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace CatCha
{
    public partial class Frm_Cart3 : Form
    {
        public Frm_Cart3(/*List<CarttoBill>carttoBills,string total*/)
        {
            InitializeComponent();
            //LoadCartItem(carttoBills,total);

        }

        int i = 0;
        internal void LoadCartItem(List<CarttoBill> cartItems,string total)
        {
            this.labCartTotal.Text = total;
            foreach (var cartItem in cartItems)
            {
                //第一種寫法
                string[] items = { cartItem.productName, cartItem.productCount, cartItem.productPrice.ToString() };
                //每一列的第一格加上空字串
                orderListView.Items.Add("");
                //每一列按照順序加上productName,productCount,productPrice
                orderListView.Items[i++].SubItems.AddRange(items);

                //第二種寫法
                //ListViewItem item = new ListViewItem();
                //item.SubItems.Add(cartItem.productName);
                //item.SubItems.Add(cartItem.productCount);
                //item.SubItems.Add(cartItem.productPrice.ToString());
                //listView1.Items.Add(item);

            }
        }


        private void Frm_Cart3_Load(object sender, EventArgs e)
        {
            this.labCartTotal.Text = $" 商品金額：{CarttoBill.CartTotal:c2}";
            this.labShippment.Text = $" 運費：{CarttoBill.Shippment:c2}";
            this.labDiscount.Text = $" 折扣：- {CarttoBill.PointsValue+CarttoBill.Discount:c2}";
            this.labOrderTotal.Text = $" 總計：{CarttoBill.OrderTotal:c0}";
            this.labPaymentMethod.Text = $"付款方式：{CarttoBill.PaymentMethod}";
        }
    }
}
