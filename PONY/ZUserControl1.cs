using CatCaha.BuySomeThing;
using CatCaha.IbuySomeThing;
using CatCaha.ProductsList;
using CatCaha.UserDataSouce;
using CatCaha.CallDataToFormm;
using CatCaha.ZongHanCompoents.UserOderData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using CatCaha.ZongHanCompoents.IbuySomeThing;
using System.Threading;
using FormResize;

namespace CatCaha
{
    public partial class ZUserControl1 : UserControl
    {
        GlobelSetting globelSetting = new GlobelSetting();
        private BuyItems buyItems;
        private IUserProperties user;
        private IProductsProperties product;
        private ChargeCoin coin;
        private UserDataFromLinq userDataList = new UserDataFromLinq();
        private GamePurchasePage gamePurchasePage;

        private Frm_GameMain mainForm;
        public ZUserControl1()
        {
            InitializeComponent();

            button1.Region = new Region(CreateRoundRectPath(button1.ClientRectangle, 10));
            button2.Region = new Region(CreateRoundRectPath(button1.ClientRectangle, 10));
            this.Click += UserControl_Click;
            this.button1.Click += Button_Click;
            this.button1.BackColor = ColorTranslator.FromHtml("#E4BB97");
            this.button2.Click += Button1_click;
            this.button2.BackColor = ColorTranslator.FromHtml("#E4BB97");
            this.buyItems = new BuyItems();
            user = user;
            product = product;
            coin = new ChargeCoin();
            mainForm = new Frm_GameMain();
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private GraphicsPath CreateRoundRectPath(Rectangle rectangle, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = cornerRadius * 2;
            path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            path.AddArc(rectangle.Right - radius, rectangle.Y, radius, radius, 270, 90);
            path.AddArc(rectangle.Right - radius, rectangle.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rectangle.X, rectangle.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void Button1_click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("確定要使用紅利嗎?", "付費方式", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                UserDataFromLinq userDataList = new UserDataFromLinq();
                UserData userd = userDataList.GetUserDatas().First();
                user = new UserProperties(userd);

                IProductsProperties product = new ProductsProperties();
                product.ProductsPrice = int.Parse(this.label3.Text);
                product.ProductID = int.Parse(this.label4.Text);

                string result = buyItems.BuyWithLoyaltyPoints(user, product);

                if (result == "成功")
                {

                    globelSetting._REFRESHRuby(mainForm.txt_RedStone);
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("確定要使用貓幣嗎?", "付費方式", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                UserDataFromLinq userDataList = new UserDataFromLinq();
                UserData userd = userDataList.GetUserDatas().First();
                user = new UserProperties(userd);

                //// Create and initialize a new ProductsProperties instance
                IProductsProperties product = new ProductsProperties();
                product.ProductsPrice = int.Parse(this.label3.Text);
                product.ProductID = int.Parse(this.label4.Text);

                //// Use the newly created user and product objects here
                string result = buyItems.BuyWithCatcoin(user, product);

                MessageBox.Show(result);

                if(result == "成功")
                {
                    globelSetting._REFRESHCCoin(mainForm.txt_CatCoin);
                }
                else if(result == "額度不足")
                {
                    string input = Microsoft.VisualBasic.Interaction.InputBox("請輸入需要充值金額:", "Charge", "0", -1, -1);
                    int amount;

                    // If the input is not a valid integer, show an error message and return
                    if (!int.TryParse(input, out amount))
                    {
                        MessageBox.Show("要輸入整數定值");
                        return;
                    }

                    // Create a new Charge object
                    ChargeAmount charge = new ChargeAmount() { Amount = amount };

                    // Charge the user's account
                    string chargeResult = coin.chargeCoin(user, charge);

                    // Display the result
                    MessageBox.Show(chargeResult);
                }

            }
            
        }

        public void UserControl_Click(object sender, EventArgs e)
        {
            detilView showForm = new detilView();
            showForm.Owner = this.GamePurchasePage;
            showForm.SetImage(this.pictureBox1.Image);
            showForm.SetLabel1Text(this.label1.Text);
            showForm.SetLabe2Text(this.label2.Text.ToString());
            showForm.SetUserAndProduct(user, product);
            showForm.ShowDialog();
        }


        public void SetImage(Image image)
        {
            this.pictureBox1.Image = image;
        }

        public void ClearData()
        {
            this.pictureBox1.Image = null;
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

        public void SetProductID(int id)
        {
           this.label4.Text = id.ToString();
        }

        public string Label3Text
        {
            get { return label3.Text; }
            set { label3.Text = value; }
        }
        public GamePurchasePage GamePurchasePage
        {
            get { return gamePurchasePage; }
            set { gamePurchasePage = value; }
        }

        public Frm_GameMain frm_GameMain { get { return frm_GameMain; } set { frm_GameMain = value; } }
    }
}
