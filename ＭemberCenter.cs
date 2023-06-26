using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqLabs
{
    public partial class ＭemberCenter : Form
    {
        public ＭemberCenter()
        {
            InitializeComponent();

            button1_Click(null, EventArgs.Empty);
        }


        //button1是  個人資訊頁面
        private void button1_Click(object sender, EventArgs e)
        {
            MemberInformation form = new MemberInformation();
            ShowForm(form);
        }

        //button2是  消費紀錄查詢
        private void button2_Click(object sender, EventArgs e)
        {
            ConsumptionRecord form = new ConsumptionRecord();
            ShowForm(form);
        }

        //button3是  退貨/退款狀態
        private void button3_Click(object sender, EventArgs e)
        {
            RefundStatus form = new RefundStatus();
            ShowForm(form);
        }

        //button4是  個人成績查詢
        private void button4_Click(object sender, EventArgs e)
        {

            PersonalAchievement form = new PersonalAchievement();
            ShowForm(form);
        }

        //button5是  遊戲專區
        private void button5_Click(object sender, EventArgs e)
        {

            Game form = new Game();
            ShowForm(form);
        }

        //button6是  客服信件紀錄查詢
        private void button6_Click(object sender, EventArgs e)
        {

            CustomerService form = new CustomerService();
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
    }
}
