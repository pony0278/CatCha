using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatCaha.NewFolder1;
using LinqLabs;

namespace CatChaForms
{
    public partial class Signin : Form
    {
        貓抓抓Entities1 dbContext = new 貓抓抓Entities1();
        internal object panelOverlay;

        public Signin()
        {
            this.Activated += YourForm_Activated; //winform表單一開始執行時，不要focus在textbox上
            InitializeComponent();
        }

        private void YourForm_Activated(object sender, EventArgs e)
        {
            this.ActiveControl = null; // 清除焦點
            this.Activated -= YourForm_Activated; // 取消事件綁定
        }

        //==============先做異常檢測
        private bool checkTextBox()
        {
            ClearErrorLabels(); // 清除之前的错误消息
            bool check = true; //默認為true

            //異常檢測
            if (txtAccount.Text.Trim() == "" || txtAccount.Text == "請輸入email")
            {
                SetErrorLabel(SigninMsg, "請輸入帳號");
                check = false;
            }
            else if (txtPwd.Text.Trim() == "")
            {
                SetErrorLabel(SigninMsg, "請輸入密碼");
                check = false;
            }
            return check;
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            // 帳號
            string loginAcc = txtAccount.Text;
            // 密碼
            string loginPwd = txtPwd.Text;

            string hashAlgorithm = "SHA1"; // 哈希算法
            if (checkTextBox())
            {
                try
                {
                    Shop_Member_Info user = dbContext.Shop_Member_Info.FirstOrDefault(u => u.Member_Account == loginAcc);

                    // 验证是否有此會員
                    if (user != null)
                    {
                        // 哈希加密提供的密码
                        string hashedPassword = HashPassword(loginPwd, hashAlgorithm);

                        // 验证哈希后的密码是否匹配数据库中的哈希值
                        if (user.Password == hashedPassword)
                        //if (user.Password == loginPwd)
                        {

                            //============記住登入的使用者資訊
                            //LoggedInUser.ID = user.Member_ID;
                            LoggedInUser.SetID(user.Member_ID);

                            LoggedInUser.Username = user.Name;



                            // 驗證成功
                            SetErrorLabel(SigninMsg, "登入成功");

                            // 驗證成功
                            MessageBox.Show("Hello~" + user.Name + "，歡迎回來!");
                            this.Close();
                        }
                        else
                        {
                            // 密碼不匹配
                            SetErrorLabel(SigninMsg, "密碼有誤，請重新輸入");
                        }
                    }
                    else
                    {
                        // 用户名不存在
                        SetErrorLabel(SigninMsg, "此帳戶不存在，請重新輸入");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // 哈希密碼
        private string HashPassword(string password, string hashAlgorithm)
        {
            // 哈希算法對密碼進行加密
            string hashedPassword = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(password, hashAlgorithm);
            return hashedPassword;
        }

        private void ClearErrorLabels()
        {
            // 清除其他错误消息的 Label 可见性...
            SigninMsg.Visible = false;
        }

        private void SetErrorLabel(System.Windows.Forms.Label errorLabel, string errorMessage)
        {
            errorLabel.Text = errorMessage;
            errorLabel.Visible = true;
        }

        private void Signin_Load(object sender, EventArgs e)
        {
            txtAccount.Text = "請輸入email";
            txtAccount.ForeColor = Color.DarkGray;
        }

        private void txtAccount_Enter(object sender, EventArgs e)
        {
            if (txtAccount.Text == "請輸入email")
            {
                txtAccount.Text = "";
                txtAccount.ForeColor = Color.DarkGray;
            }
        }

        private void txtAccount_Leave(object sender, EventArgs e)
        {
            if (txtAccount.Text == "")
            {
                txtAccount.Text = "請輸入email";
                txtAccount.ForeColor = Color.DarkGray;
            }
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            txtPwd.PasswordChar = '*'; //設定密碼顯示跟網頁一樣不顯示內容
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup form = new Signup();
            form.ShowDialog();
            this.Hide(); //關閉登入的視窗
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPwd form = new ForgetPwd();
            form.ShowDialog();
            this.Hide(); //關閉登入的視窗
        }
    }
}
