using CatCaha.BuySomeThing;
using CatCaha.IbuySomeThing;
using CatCaha.ProductsList;
using CatCaha.UserDataSouce;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatCaha
{
    public partial class detilView : Form
    {
        BuyItems buyItems = new BuyItems();
        private IUserProperties user;
        private IProductsProperties product;

        public detilView()
        {
            InitializeComponent();
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        public void SetImage(Image image)
        {
            this.pictureBox1.Image = image;
        }

        public void SetLabel1Text(string text)
        {
            this.label1.Text = text.ToString();
        }
        public void SetLabe2Text(string text)
        {
            this.label2.Text = text;
        }

        public void SetUserAndProduct(IUserProperties user, IProductsProperties product)
        {
            this.user = user;
            this.product = product;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = buyItems.BuyWithCatcoin(user, product);
            MessageBox.Show($"{result}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = buyItems.BuyWithLoyaltyPoints(user, product);
            MessageBox.Show($"{result}");
        }
    }
}
