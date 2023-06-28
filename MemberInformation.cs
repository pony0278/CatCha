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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LinqLabs
{
    public partial class MemberInformation : Form
    {
        public MemberInformation()
        {
            InitializeComponent();

            prepareMaterials();
        }

        //載入預設資料
        private void prepareMaterials()
        {
            var q = from p in dbContext.Shop_會員資訊
                    where p.會員ID == 1
                    select new
                    {
                        會員帳號 = p.會員帳號,
                        密碼 = p.密碼,
                        姓名 = p.姓名,
                        電子郵件 = p.電子郵件,
                        手機號碼 = p.手機號碼,
                        地址 = p.地址,
                    };

            var result = q.FirstOrDefault();

            textBox1.Text = result.會員帳號.ToString();
            //textBox2.Text = new string('*', result.密碼.Length);
            textBox2.Text = result.密碼.ToString();
            textBox3.Text = result.姓名.ToString();
            textBox4.Text = result.電子郵件.ToString();
            textBox5.Text = result.手機號碼.ToString() ;
            textBox6.Text = result.地址.ToString();
        }

        貓抓抓Entities dbContext = new 貓抓抓Entities();
        //放在類別中供各地方可使用全域，先讓dbContext取得資料

        //會員密碼修改
        private void button7_Click(object sender, EventArgs e)
        {

        }

        //玩家姓名修改
        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "修改")
            {
                button8.Text = "確定";
                button8.BackColor = Color.Yellow;
                textBox3.ReadOnly = false;
                textBox3.Enabled = true;
            } 
            else if (button8.Text =="確定" && string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("請於框中輸入資料");
            }
            else if (button8.Text == "確定")
            {
                button8.Text = "修改";
                button8.BackColor = Color.Gainsboro;
                MessageBox.Show("修改成功");
                textBox3.ReadOnly = true;
                textBox3.Enabled = false;
            }
            else
            {
                MessageBox.Show("您輸入的資料格式不正確");
            }
        }

        //電子郵件修改
        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "修改")
            {
                button9.Text = "確定";
                button9.BackColor = Color.Yellow;
                textBox4.ReadOnly = false;
                textBox4.Enabled = true;
            }
            else if (button9.Text == "確定" && string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("請於框中輸入資料");
            }
            else if (button9.Text == "確定")
            {
                button9.Text = "修改";
                button9.BackColor = Color.Gainsboro;
                MessageBox.Show("修改成功");
                textBox4.ReadOnly = true;
                textBox4.Enabled = false;
            }
            else
            {
                MessageBox.Show("您輸入的資料格式不正確");
            }
        }

        //手機號碼修改
        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Text == "修改")
            {
                button10.Text = "確定";
                button10.BackColor = Color.Yellow;
                textBox5.ReadOnly = false;
                textBox5.Enabled = true;
            }
            else if (button10.Text == "確定" && string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("請於框中輸入資料");
            }
            else if (button10.Text == "確定")
            {
                button10.Text = "修改";
                button10.BackColor = Color.Gainsboro;
                MessageBox.Show("修改成功");
                textBox5.ReadOnly = true;
                textBox5.Enabled = false;
            }
            else
            {
                MessageBox.Show("您輸入的資料格式不正確");
            }
        }

        //通訊地址修改
        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.Text == "修改")
            {
                button11.Text = "確定";
                button11.BackColor = Color.Yellow;
                textBox6.ReadOnly = false;
                textBox6.Enabled = true;
            }
            else if (button11.Text == "確定" && string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("請於框中輸入資料");
            }
            else if (button11.Text == "確定")
            {
                button11.Text = "修改";
                button11.BackColor = Color.Gainsboro;
                MessageBox.Show("修改成功");
                textBox6.ReadOnly = true;
                textBox6.Enabled = false;
            }
            else
            {
                MessageBox.Show("您輸入的資料格式不正確");
            }
        }

    }
}
