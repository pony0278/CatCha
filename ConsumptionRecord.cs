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
    public partial class ConsumptionRecord : Form
    {
        public ConsumptionRecord()
        {
            InitializeComponent();

            dataGridView1.Rows.Add(new object[] {1, "2022-12-25", "尚未完成", "信用卡支付"});
            dataGridView1.Rows.Add(new object[] {2, "2022-08-16", "退款中", "信用卡支付"});
            dataGridView1.Rows.Add(new object[] {3, "2022-05-20", "已完成", "貓幣扣款"});
            dataGridView1.Rows.Add(new object[] {4, "2022-01-24", "已完成", "貓幣扣款"});


        }
    }
}
