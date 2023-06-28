using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public CustomerService()
        {
            InitializeComponent();

            prepareMaterials();
        }

        //載入預設資料
        private void prepareMaterials()
        {
            var q = from p in dbContext.Shop_申訴類別資料表
                    select p.類別名稱;

            comboBox1.DataSource = q.ToList();
        }

        貓抓抓Entities dbContext = new 貓抓抓Entities();
        //放在類別中供各地方可使用全域，先讓dbContext取得資料

        //發送按鈕
        private void button7_Click(object sender, EventArgs e)
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
                MessageBox.Show("發送成功，將有專人與您聯繫");
            }
        }
    }
}
