using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatCaha;
using LinqLabs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace LinqLabs
{
    public partial class CustomerService : Form
    {
        public CustomerService(int data)
        {
            InitializeComponent();

            now_Member_ID = data;

            prepareMaterials();
        }

        //載入預設資料
        private void prepareMaterials()
        {
            
            var q = from p in dbContext.Shop_Appeal_Category_Data
                    select p.Category_Name;

            comboBox1.DataSource = q.ToList();
            
        }


        //發送按鈕
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("請輸入標題");
                }
                else if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("請輸入內容");
                }
                else
                {
                    Shop_Member_Complaint_Case detail = new Shop_Member_Complaint_Case 
                    { 
                        Complaint_Title = textBox1.Text,
                        Member_ID = now_Member_ID,
                        Complaint_Content = textBox2.Text,
                        Complaint_Status_ID = 1,
                        Complaint_Category_ID = comboBox1.SelectedIndex + 1,
                        Creation_Time = DateTime.Now,
                    };

                    dbContext.Shop_Member_Complaint_Case.Add(detail);

                    dbContext.SaveChanges();

                    MessageBox.Show("發送成功，將有專人與您聯繫");

                    textBox1.Clear();
                    textBox2.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        int now_Member_ID;
        貓抓抓Entities1 dbContext = new 貓抓抓Entities1();
        //放在類別中供各地方可使用全域，先讓dbContext取得資料

        //傳遞資料
        public int DataProperty { get; set; }
    }
}
