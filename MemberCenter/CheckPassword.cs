using CatCaha;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CatCaha
{
    public partial class CheckPassword : Form
    {
        public CheckPassword()
        {
            InitializeComponent();

            now_Member_ID = DataProperty;
        }

        //確認送出
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                now_Member_ID = DataProperty;

                // 取得要修改的資料
                var q = dbContext.Shop_Member_Info.FirstOrDefault(p => p.Member_ID == now_Member_ID);

                //如果有空格
                if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                    string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("請於框中輸入資料。");
                }
                else if ( textBox2.Text != textBox3.Text)
                {
                    MessageBox.Show("新密碼前後輸入不一致。");
                }
                else if(textBox1.Text != q.Password)
                {
                    MessageBox.Show("原密碼不正確。");
                }
                else
                {
                    q.Password = textBox3.Text;
                    dbContext.SaveChanges();

                    MessageBox.Show("密碼變更成功。");

                    this.Close();
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


