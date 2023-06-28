using CatCaha;
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
    public partial class RefundStatus : Form
    {
        public RefundStatus()
        {
            InitializeComponent();

            dataGridView1.Rows.Add(new object[] { 1, "2022-12-25", "尚未完成", "信用卡支付" });
            dataGridView1.Rows.Add(new object[] { 2, "2022-08-16", "退款中", "信用卡支付" });
            dataGridView1.Rows.Add(new object[] { 3, "2022-05-20", "已完成", "貓幣扣款" });
            dataGridView1.Rows.Add(new object[] { 4, "2022-01-24", "已完成", "貓幣扣款" });
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                DataGridViewCell clickedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string cellText = clickedCell.Value.ToString();

                if (cellText == "明細")
                {
                    ReturnDetails detailForm = new ReturnDetails();
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
    }
}
