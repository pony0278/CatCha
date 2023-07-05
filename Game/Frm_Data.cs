using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatCaha.ZongHanCompoents.UserOderData;

namespace FormResize
{
    public partial class Frm_Data : Form
    {
        userGameOrderFromLinq q = new userGameOrderFromLinq();

        public Frm_Data()
        {
            InitializeComponent();
            q.GetAllOderWithPic();
            dataGridView1.DataSource = q.GetAllOderWithPic();
        }
    }
}
