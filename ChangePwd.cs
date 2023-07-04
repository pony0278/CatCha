using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatChaForms
{
    public partial class ChangePwd : Form
    {
        貓抓抓Entities dbContext = new 貓抓抓Entities();
        public ChangePwd()
        {
            InitializeComponent();
        }

        private bool checkTextBox()
        {
            ClearErrorLabels(); // 清除之前的错误消息
            bool check = true; //默認為true

            //異常檢測
            if (newPwd.Text.Trim() == "")
            {
                SetErrorLabel(label4, "請輸入新密碼");
                check = false;
            }
            else if (newCheckPwd.Text.Trim() == "")
            {
                SetErrorLabel(label4, "請再次輸入新密碼");
                check = false;
            }
            else if (newCheckPwd.Text.Length <= 6)
            {
                SetErrorLabel(label4, "新密碼需大於6個字元");
                check = false;
            }
            else if (newPwd.Text != newCheckPwd.Text)
            {
                SetErrorLabel(label4, "新密碼與確認新密碼不相符，請重新輸入");
                check = false;
            }
            return check;
        }

        private void changepassword_Click(object sender, EventArgs e)
        {
            if (checkTextBox())
            {
                try
                {
                    Shop_Member_Info user = dbContext.Shop_Member_Info.FirstOrDefault(u => u.Member_Account == ForgetPwd.userAcc);

                    //密碼加密
                    string NewPassword = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(this.newPwd.Text, "sha1");

                    if (user != null)
                    {
                        user.Password = NewPassword; // 将原密码字段修改为新值
                        dbContext.SaveChanges(); // 保存更改到数据库
                        //==================提示訊息
                        MessageBox.Show("修改密碼成功！請重新登入。");
                        //==================跳轉到哪一頁
                        Signin form = new Signin();
                        form.Show();
                        this.Hide(); //關閉登入的視窗
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ChangePwd_Load(object sender, EventArgs e)
        {
            label4.Text = "你好," + ForgetPwd.userAcc;
        }

        private void ClearErrorLabels()
        {
            label4.Visible = false;
        }

        private void SetErrorLabel(System.Windows.Forms.Label errorLabel, string errorMessage)
        {
            errorLabel.Text = errorMessage;
            errorLabel.Visible = true;
        }

        private void newPwd_TextChanged(object sender, EventArgs e)
        {
            newPwd.PasswordChar = '*'; //設定密碼顯示跟網頁一樣不顯示內容
        }

        private void newCheckPwd_TextChanged(object sender, EventArgs e)
        {
            newCheckPwd.PasswordChar = '*'; //設定密碼顯示跟網頁一樣不顯示內容
        }
    }
}
