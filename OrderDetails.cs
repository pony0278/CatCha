using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatCaha
{
    public partial class OrderDetails : Form
    {
        public OrderDetails()
        {
            InitializeComponent();

            dataGridView1.Rows.Add(new object[] { "砂盆A12型", 120, 2 });
            dataGridView1.Rows.Add(new object[] { "寵愛貓糧", 36, 3 });
            dataGridView1.Rows.Add(new object[] { "逗貓棒B11型", 45, 1 });
            dataGridView1.Rows.Add(new object[] { "貓專屬跳台(101造型)", 500, 1 });
        }
    }
}
