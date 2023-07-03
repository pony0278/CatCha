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
        public MemberInformation(int data)
        {
            InitializeComponent();

            now_Member_ID = data;

            prepareMaterials();

        }

        

        //載入預設資料
        private void prepareMaterials()
        {

            try
            {
                var q = from p in dbContext.Shop_Member_Info
                        where p.Member_ID == now_Member_ID
                        select new
                        {
                            會員帳號 = p.Member_Account,
                            密碼 = p.Password,
                            會員姓名 = p.Name,
                            角色名稱 = p.Character_Name,
                            電子郵件 = p.Email,
                            手機號碼 = p.Phone_Number,
                            地址 = p.Address,
                        };

                var result = q.FirstOrDefault();

                textBox1.Text = result.會員帳號.ToString();
                textBox2.Text = result.密碼.ToString();
                textBox7.Text = result.會員姓名.ToString() ;
                textBox3.Text = result.角色名稱.ToString();
                textBox4.Text = result.電子郵件.ToString();
                textBox5.Text = result.手機號碼.ToString();
                textBox6.Text = result.地址.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //會員密碼修改
        private void button7_Click(object sender, EventArgs e)
        {
            CheckPassword form = new CheckPassword();
            form.StartPosition = FormStartPosition.CenterParent;
            form.DataProperty = now_Member_ID;
            form.ShowDialog();
        }

        //會員姓名修改
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (button1.Text == "修改")
                {
                    button1.Text = "確定";
                    button1.BackColor = Color.Yellow;
                    textBox7.ReadOnly = false;
                    textBox7.Enabled = true;
                }
                else if (button1.Text == "確定" && string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    MessageBox.Show("請於框中輸入資料");
                }
                else if (button1.Text == "確定")
                {
                    button1.Text = "修改";
                    button1.BackColor = Color.Gainsboro;

                    // 取得要修改的資料
                    var q = dbContext.Shop_Member_Info.FirstOrDefault(p => p.Member_ID == now_Member_ID);

                    q.Name = textBox7.Text;
                    dbContext.SaveChanges();

                    MessageBox.Show("修改成功");
                    textBox7.ReadOnly = true;
                    textBox7.Enabled = false;
                }
                else
                {
                    MessageBox.Show("您輸入的資料格式不正確");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //角色名稱修改
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (button8.Text == "修改")
                {
                    button8.Text = "確定";
                    button8.BackColor = Color.Yellow;
                    textBox3.ReadOnly = false;
                    textBox3.Enabled = true;
                }
                else if (button8.Text == "確定" && string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("請於框中輸入資料");
                }
                else if (button8.Text == "確定")
                {
                    button8.Text = "修改";
                    button8.BackColor = Color.Gainsboro;

                    // 取得要修改的資料
                    var q = dbContext.Shop_Member_Info.FirstOrDefault(p => p.Member_ID == now_Member_ID);

                    q.Character_Name = textBox3.Text;
                    dbContext.SaveChanges();

                    MessageBox.Show("修改成功");
                    textBox3.ReadOnly = true;
                    textBox3.Enabled = false;
                }
                else
                {
                    MessageBox.Show("您輸入的資料格式不正確");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //電子郵件修改
        private void button9_Click(object sender, EventArgs e)
        {
            try
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

                    // 取得要修改的資料
                    var q = dbContext.Shop_Member_Info.FirstOrDefault(p => p.Member_ID == now_Member_ID);

                    q.Email = textBox4.Text;
                    dbContext.SaveChanges();

                    MessageBox.Show("修改成功");
                    textBox4.ReadOnly = true;
                    textBox4.Enabled = false;
                }
                else
                {
                    MessageBox.Show("您輸入的資料格式不正確");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //手機號碼修改
        private void button10_Click(object sender, EventArgs e)
        {
            try
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

                    // 取得要修改的資料
                    var q = dbContext.Shop_Member_Info.FirstOrDefault(p => p.Member_ID == now_Member_ID);

                    q.Phone_Number = textBox5.Text;
                    dbContext.SaveChanges();

                    MessageBox.Show("修改成功");
                    textBox5.ReadOnly = true;
                    textBox5.Enabled = false;
                }
                else
                {
                    MessageBox.Show("您輸入的資料格式不正確");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //通訊地址修改
        private void button11_Click(object sender, EventArgs e)
        {
            try
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

                    // 取得要修改的資料
                    var q = dbContext.Shop_Member_Info.FirstOrDefault(p => p.Member_ID == now_Member_ID);

                    q.Address = textBox6.Text;
                    dbContext.SaveChanges();

                    MessageBox.Show("修改成功");
                    textBox6.ReadOnly = true;
                    textBox6.Enabled = false;
                }
                else
                {
                    MessageBox.Show("您輸入的資料格式不正確");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        int now_Member_ID;
        貓抓抓Entities1 dbContext = new 貓抓抓Entities1();

        //傳遞資料
        public int DataProperty { get; set; }

    }
}
