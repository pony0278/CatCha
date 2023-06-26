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
    public partial class UserControl1 : UserControl
    {
        private BuyItems buyItems;
        private IUserProperties user;
        private IProductsProperties product;

        public UserControl1()
        {
            InitializeComponent();
            this.buyItems = new BuyItems();
            user = user;
            product = product;
            this.Click += UserControl_Click;
            this.button1.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            UserDataList userDataList = new UserDataList();
            UserData userd = userDataList.GetUserDatas().First();
            user = new UserProperties(userd);
            MessageBox.Show($"{user.CatCoin}");


            //// Create and initialize a new ProductsProperties instance
            IProductsProperties product = new ProductsProperties();
            product.ProductsPrice = int.Parse(this.label2.Text);  // Example value

            //// Use the newly created user and product objects here
            string result = buyItems.Buy(user, product);

            MessageBox.Show(result);
        }

        public void UserControl_Click(object sender, EventArgs e)
        {
            detilView showForm = new detilView();
            showForm.SetImage(this.pictureBox1.Image);
            showForm.SetLabel1Text(int.Parse(this.label1.Text));
            showForm.SetLabe2Text(this.label2.Text.ToString());
            showForm.Show();
        }

        public void SetImage(Image image)
        {
            this.pictureBox1.Image = image;
        }

        public void ClearData()
        {
            // Set the Image to null or to a default image.
            this.pictureBox1.Image = null;

            // Set the Text to an empty string or a default string.
            this.label1.Text = string.Empty;
        }

        public void SetProductName(string text)
        {
            this.label1.Text = text.ToString();
        }
        public void SetProductPrice(int text)
        {
            this.label3.Text = text.ToString();
        }

        public void SetProductDesprict(string text)
        {
            this.label2.Text = text.ToString();
        }
    }
}
