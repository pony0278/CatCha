using CatChaForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace LinqLabs
{
    public partial class ＭemberCenter : Form
    {
        public ＭemberCenter()
        {
            InitializeComponent();

            //載入時，讓panel停留在個人資訊頁面
            button1_Click(null, EventArgs.Empty);
        }


        //button1是  個人資訊頁面
        private void button1_Click(object sender, EventArgs e)
        {
            MemberInformation form = new MemberInformation(now_Member_ID);
            ShowForm(form);

        }

        //button2是  商城消費紀錄
        private void button2_Click(object sender, EventArgs e)
        {
            ConsumptionRecord form = new ConsumptionRecord(now_Member_ID);
            ShowForm(form);
        }

        //button3是  退貨/換貨紀錄
        private void button3_Click(object sender, EventArgs e)
        {
            RefundStatus form = new RefundStatus(now_Member_ID);
            form.DataProperty = now_Member_ID;
            ShowForm(form);
        }

        //button4是  個人成就查詢
        private void button4_Click(object sender, EventArgs e)
        {

            PersonalAchievement form = new PersonalAchievement(now_Member_ID);
            form.DataProperty = now_Member_ID;
            ShowForm(form);
        }


        //button6是  會員客服系統
        private void button6_Click(object sender, EventArgs e)
        {

            CustomerService form = new CustomerService(now_Member_ID);
            form.DataProperty = now_Member_ID;
            ShowForm(form);
        }

        //展示各表單的方法
        private void ShowForm(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;

            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(form);


            form.Show();
        }

        //取得使用者登入後的會員ID
        int now_Member_ID = LoggedInUser.ID;

    }
}
