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
        }


        private void btnGameMng_Click(object sender, EventArgs e)
        {
            Frm01_GameManage frm = new Frm01_GameManage();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Clear();
            this.splitContainer1.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnMembersMng_Click(object sender, EventArgs e)
        {
            Frm02_MembersManage frm = new Frm02_MembersManage();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Clear();
            this.splitContainer1.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnProductsMng_Click(object sender, EventArgs e)
        {
            Frm03_ProductsManage frm = new Frm03_ProductsManage();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Clear();
            this.splitContainer1.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnOrdersMng_Click(object sender, EventArgs e)
        {
            Frm04_OrdersManage frm = new Frm04_OrdersManage();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Clear();
            this.splitContainer1.Panel2.Controls.Add(frm);
            frm.Show();
        }
    }
}
