using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormResize
{
    public partial class Frm_Notify : Form
    {
        private Frm_GameMain mainForm;
        

      

        public Frm_Notify(Frm_GameMain ParentForm)
        {
            C_Notify notify = new C_Notify(this);
            mainForm = ParentForm;
            InitializeComponent();
            GlobelSetting._HIDEFORMCONTROL(this);
            
           
            notify._loadBTN(this.flowLayoutPanel1);
        }


        private void txtBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
