using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatChaForms
{
    public partial class success : Form
    {
        public success()
        {
            InitializeComponent();
        }
   
        int UserID = LoggedInUser.ID;
        private void success_Load(object sender, EventArgs e)
        {
            int memberID = UserID;
            string username = LoggedInUser.Username;
            label2.Text = "登入者的ID = " + memberID;
            label1.Text = "登入者的帳號 = " + username;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("確定要登出嗎?", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //===========清掉存放的值
                LoggedInUser.Logout();
                LoggedInUser.Username = null;

                //==================
                MessageBox.Show("您已登出!");
                // 关闭当前窗体
                this.Close();

                //因為在linkLabel1_LinkClicked方法執行完成後，當前表格的生命週期結束，從而導致新表格已無法正常顯示。
                // 启动新线程，并在其中运行新窗体
                //Thread newThread = new Thread(() =>
                //{
                //    Application.Run(new Signin());
                //});
                //newThread.Start();
            }
        }
    }
}
