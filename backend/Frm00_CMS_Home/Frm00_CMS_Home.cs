using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatChaEntities
{
    public partial class Frm00_CMS_Home : Form
    {
        public Frm00_CMS_Home()
        {
            InitializeComponent();
            //設定視窗位置置中螢幕及視窗大小
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1300, 800);
            this.splitContainer1.Panel2.AutoScroll = true;

            foreach (Control control in flowLayoutPanelbtn.Controls)
            {
                if (control is Button button)
                {
                    button.Anchor = AnchorStyles.None;
                    button.TextAlign = ContentAlignment.MiddleCenter;
                }
            }
        }

        private void btnRealTimeData_Click(object sender, EventArgs e)
        {
            Frm01_RealTimeData frm = new Frm01_RealTimeData();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Clear();
            this.splitContainer1.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnGameMng_Click(object sender, EventArgs e)
        {
            Frm02_GameManage frm = new Frm02_GameManage();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Clear();
            this.splitContainer1.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnPagesMng_Click(object sender, EventArgs e)
        {
            Frm03_PagesManage frm = new Frm03_PagesManage();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Clear();
            this.splitContainer1.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnMembersMng_Click(object sender, EventArgs e)
        {
            Frm04_MembersManage frm = new Frm04_MembersManage();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Clear();
            this.splitContainer1.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnProductsMng_Click(object sender, EventArgs e)
        {
            Frm05_ProductsManage frm = new Frm05_ProductsManage();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Clear();
            this.splitContainer1.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnOrdersMng_Click(object sender, EventArgs e)
        {
            Frm06_OrdersManage frm = new Frm06_OrdersManage();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Clear();
            this.splitContainer1.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnBlog_Click(object sender, EventArgs e)
        {
            Frm07_Blog frm = new Frm07_Blog();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Clear();
            this.splitContainer1.Panel2.Controls.Add(frm);
            frm.Show();
        }
    }
}
