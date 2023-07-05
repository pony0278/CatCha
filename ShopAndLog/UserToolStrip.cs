using CatChaForms;
using FormResize;
using LinqLabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatCha
{
    public partial class UserToolStrip : UserControl
    {
        public UserToolStrip()
        {
            InitializeComponent();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (LoggedInUser.ID == 0)
            {
                Signin form = new Signin();
                form.ShowDialog();
            }
            else {
                ＭemberCenter form = new ＭemberCenter();
                form.ShowDialog();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //How to close a form in UserControl
            //參考網址:
            //============寫法1
            Shopping form = new Shopping();
            form.ShowDialog();
            ((Form)this.TopLevelControl).Close();

            //============寫法2
            //Shopping form = new Shopping();
            //form.ShowDialog();
            //Form tmp = this.FindForm();
            //tmp.Close();
            //tmp.Dispose();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
          
            Frm_GameMain frm_GameMain = new Frm_GameMain();
            C_Query q = new C_Query();
            if (LoggedInUser.Username == null && LoggedInUser.ID == 0)
            {
                MessageBox.Show("請先登入");
                Signin form = new Signin();
                form.ShowDialog();
            }
            else
            {
                string GameName = LoggedInUser.Username;
                int MemberID = LoggedInUser.ID;
                GameName = MemberID.ToString();
                //...........進入遊戲畫面
                //MessageBox.Show("進入遊戲大廳");
                frm_GameMain.Show();
                //載入遊戲名稱
                frm_GameMain.txt_ID.Text = q._GameName().ToString();
                //載入貓幣金額
                frm_GameMain.txt_CatCoin.Text = q._GameCatCoin();
                //載入紅利金額
                frm_GameMain.txt_RedStone.Text = q._GameRLPoint();
            }

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (LoggedInUser.ID == 0)
            {
                Signin form = new Signin();
                form.ShowDialog();
            }
            else
            {
                Frm_Cart form = new Frm_Cart();
                form.ShowDialog();
            }
        }
    }
}
