using CatChaForms;
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

        private void tbtnMember_Click(object sender, EventArgs e)
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

        

        private void tbtnGoToCart_Click(object sender, EventArgs e)
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

        private void tbtnGoToShop_Click(object sender, EventArgs e)
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
    }
}
