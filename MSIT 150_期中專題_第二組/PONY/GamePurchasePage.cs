using CatCaha.CallDataToFormm;
using CatCaha.IcaptureData;
using CatCaha.ProductsList;
using FormResize;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CatCaha
{
    public partial class GamePurchasePage : Form
    {
        CallDataToFormm.CallDataToForm callTeacherData = new CallDataToFormm.CallDataToForm();
        Button button = new Button();
        ZUserControl1 userControl;
        
        public GamePurchasePage()
        {
            InitializeComponent();
            GlobelSetting._HIDEFORMCONTROL(this);
            button1.Tag = "1";
            button2.Tag = "2";
            button3.Tag = "3";
            button4.Tag = "4";
            callTeacherData.ShowUserData(this);
            this.button1.MouseEnter += Button1_MouseEnter;
            this.button2.MouseEnter += Button1_MouseEnter;
            this.button3.MouseEnter += Button1_MouseEnter;
            this.button4.MouseEnter += Button1_MouseEnter;
            this.button5.MouseEnter += Button1_MouseEnter;
            this.button1.MouseLeave += Button1_MouseLeave;
            this.button2.MouseLeave += Button1_MouseLeave;
            this.button3.MouseLeave += Button1_MouseLeave;
            this.button4.MouseLeave += Button1_MouseLeave;
            this.button5.MouseLeave += Button1_MouseLeave;
            //this.splitContainer1.Panel1.BackColor = ColorTranslator.FromHtml("#E4BB97");
            this.flowLayoutPanel1.AutoScroll = true;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.ForeColor = ColorTranslator.FromHtml("#9D5C63");
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.ForeColor = Color.White;
        }


        private void GamePurchasePage_Load(object sender, EventArgs e)
        {
            
            callTeacherData.ShowProducts(this, flowLayoutPanel1, button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            callTeacherData.ShowProducts(this, flowLayoutPanel1,button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            callTeacherData.ShowProducts(this, flowLayoutPanel1, button2);
        }

        public void SetCatCoin(int label)
        {
            this.label1.Text = label.ToString();
        }
        public void SetLoyalitPotint(int label)
        {
            this.label2.Text = label.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            callTeacherData.ShowProducts(this, flowLayoutPanel1, button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            callTeacherData.ShowProducts(this, flowLayoutPanel1, button4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
