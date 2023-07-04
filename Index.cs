using catcha;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatChaForms
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (LoggedInUser.Username == null && LoggedInUser.ID == 0)
            {
                MessageBox.Show("請先登入");
                Signin form = new Signin();
                form.ShowDialog();
            }
            else
            {
                //...........進入遊戲畫面
                MessageBox.Show("進入遊戲畫面");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shopping form = new Shopping();
            this.FormClosing += MainForm_FormClosing; // 订阅当前窗体的关闭事件
            this.Hide(); // 隐藏当前窗体
            form.Show();

            //Shop targetForm = new Shop(); // 创建目标页的实例
            //// 订阅目标页的 FormClosed 事件
            //targetForm.FormClosed += (s, args) => this.Show(); // 在目标页关闭时显示 HomeForm

            //targetForm.Show(); // 显示目标页
            //this.Hide(); // 隐藏当前页（主页）
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // 取消当前窗体的关闭操作
                this.Show(); // 显示当前窗体
            }
        }
    }
}
