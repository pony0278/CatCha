using CatCaha;
using System.Windows.Forms;
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

            dataGridView1.Rows.Add(new object[] { 1, "2022-12-25", "尚未完成", "信用卡支付" });
            dataGridView1.Rows.Add(new object[] { 2, "2022-08-16", "退款中", "信用卡支付" });
            dataGridView1.Rows.Add(new object[] { 3, "2022-05-20", "已完成", "貓幣扣款" });
            dataGridView1.Rows.Add(new object[] { 4, "2022-01-24", "已完成", "貓幣扣款" });
        }

        //gpt建議放入的事件
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            

        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                DataGridViewCell clickedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string cellText = clickedCell.Value.ToString();

                if (cellText == "明細")
                {
                    OrderDetails detailForm = new OrderDetails();
                    detailForm.StartPosition = FormStartPosition.Manual;
                    detailForm.Location = new Point(
                        this.Location.X + (this.Width - detailForm.Width) / 2,
                        this.Location.Y + (this.Height - detailForm.Height) / 2
                    );
                    detailForm.ShowDialog();
                    detailForm.BringToFront();


                }
            }
        }

        //搜尋按鈕
        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = textBox1.Text.Trim();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool found = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(keyword))
                    {
                        found = true;
                        break;
                    }
                }

                row.Visible = found;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
