using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatCaha.NewFolder1;

namespace CatCaha.MemberCenter
{
    public partial class test1 : Form
    {
        public test1()
        {
            InitializeComponent();

            now_Member_ID = 13;

        }





            //測試
            /*
            var q = from p in dbContext.Shop_Order_Detail_Table
                    where p.Order_Detail_ID == 1
                    select new
                    {
                        a = p.Product_ID
                        //收件人 = p.Recipient_Name,
                        //收件電話 = int.Parse(p.Recipient_Phone.Value.ToString())
                    };

            var item = q.ToList();

            if (item.Count > 0)
            {
                MessageBox.Show(item[0].a.ToString());
            }
            */

            //測試
            /*
            var q = from p in dbContext.Shop_Order_Total_Table.AsEnumerable()
                    where p.Order_ID == 3
                    select new
                    {
                        收件人 = p.Recipient_Name,

                        收件電話 = int.Parse(p.Recipient_Phone.Value.ToString())
                    };

            var item = q.ToList();

            if (item.Count > 0)
            {
                MessageBox.Show(item[0].收件電話.ToString());
            }
            */


        int now_Member_ID;
        project123Entities dbContext = new project123Entities();

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewTextBoxCell textboxcell = new DataGridViewTextBoxCell();
            textboxcell.Value = "aaa";
            row.Cells.Add(textboxcell);
            DataGridViewComboBoxCell comboxcell = new DataGridViewComboBoxCell();
            row.Cells.Add(comboxcell);
            dataGridView1.Rows.Add(row);





            //測試
            /*
            try
            {
                var q = dbContext.Shop_Order_Total_Table
                        .Where(p => p.Order_ID == 13)
                        .Select(p => p.Recipient_Phone)
                        .DefaultIfEmpty();

                string qValue = "0" + q.Average();

                MessageBox.Show(qValue);

                //測試
                /*
                var q = dbContext.Shop_Order_Total_Table
                    .Where(p => p.Order_ID == 13)
                    .Select ( p => p.Recipient_Phone)
                    .DefaultIfEmpty();

                MessageBox.Show(q.Average().ToString());
                */

            //測試
            /*
            var q = from p in dbContext.Shop_Order_Total_Table
                        //where p.Member_ID == 1013
                    where p.Order_ID == 13
                    orderby p.Order_ID descending
                    select new
                    {
                        訂單編號 = p.Order_ID,
                        成立日期 = (DateTime)p.Order_Creation_Date,
                        訂單狀態 = p.Shop_Order_Status_Data.Status_Name,
                        付款方式 = p.Shop_Payment_Method_Data.Payment_Method_Name,

                        a = p.Payment_Method_ID,
                        b = p.Recipient_Name,
                    };

            var queryResult = q.DefaultIfEmpty();

            //逐行將資料加入到指定格子內
            foreach (var item in queryResult)
            {
                MessageBox.Show(item.訂單編號.ToString());
            }
            */
        //}
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    */

        }
        //放在類別中供各地方可使用全域，先讓dbContext取得資料
    }
}
