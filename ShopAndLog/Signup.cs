using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatCaha.NewFolder1;

namespace CatChaForms
{
    public partial class Signup : Form
    {
        貓抓抓Entities1 dbContext = new 貓抓抓Entities1();
        public Signup()
        {
            InitializeComponent();
            this.Activated += YourForm_Activated; //winform表單一開始執行時，不要focus在textbox上
            this.GenderComboBox.SelectedIndex = 0; //性別預設先選第一個
            //生日一開始預設的日期先給值
            BirthDateTimePicker.Value = DateTime.Today.AddYears(-10);
            //禁止使用者選擇未來日期 //實際測試用輸入的也會被擋回
            BirthDateTimePicker.MaxDate = DateTime.Today;
        }

        private void YourForm_Activated(object sender, EventArgs e)
        {
            this.ActiveControl = null; // 清除焦點
            this.Activated -= YourForm_Activated; // 取消事件綁定
        }

        private bool ValidateInputs()
        {
            ClearErrorLabels(); // 清除之前的错误消息
            bool isValid = true; // 默认为 true

            //========帳號
            if (string.IsNullOrWhiteSpace(AccountText.Text))
            {
                SetErrorLabel(errorAcc, "請輸入帳號");
                isValid = false;
            }
            else if (!Regex.IsMatch(AccountText.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                SetErrorLabel(errorAcc, "帳號email格式不符");
                isValid = false;
            }
            else if (IsAccountExists(AccountText.Text))
            {
                SetErrorLabel(errorAcc, "帳號已存在");
                isValid = false;
            }

            //========姓名
            if (string.IsNullOrWhiteSpace(NameText.Text))
            {
                SetErrorLabel(errorName, "請輸入姓名");
                isValid = false;
            }

            //========電子郵件
            if (string.IsNullOrWhiteSpace(EmailText.Text))
            {
                SetErrorLabel(errorEmail, "請輸入電子郵件");
                isValid = false;
            }
            else if (!Regex.IsMatch(EmailText.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                SetErrorLabel(errorEmail, "email格式不符");
                isValid = false;
            }

            //========手機號碼
            if (string.IsNullOrWhiteSpace(CellPhoneText.Text))
            {
                SetErrorLabel(errorCellPhone, "請輸入手機號碼");
                isValid = false;
            }
            else if (!Regex.IsMatch(CellPhoneText.Text, @"^09\d{8}$"))
            {
                SetErrorLabel(errorCellPhone, "手機號碼應為09開頭且10位數");
                isValid = false;
            }

            //地址
            if (string.IsNullOrWhiteSpace(AddressText.Text))
            {
                SetErrorLabel(errorAddress, "請輸入地址");
                isValid = false;
            }

            //密碼
            if (string.IsNullOrWhiteSpace(PasswordText.Text))
            {
                SetErrorLabel(errorPwd, "請輸入密碼");
                isValid = false;
            }

            //確認密碼
            if (string.IsNullOrWhiteSpace(CheckPwdText.Text))
            {
                SetErrorLabel(errorCheckPwd, "請再次輸入密碼");
                isValid = false;
            }

            if (PasswordText.Text != CheckPwdText.Text)
            {
                SetErrorLabel(errorCheckPwd, "確認密碼與密碼不相符");
                isValid = false;
            }

            return isValid;
        }


        private void ClearErrorLabels()
        {
            // 清除其他错误消息的 Label 可见性...
            errorAcc.Visible = false;
            errorName.Visible = false;
            errorEmail.Visible = false;
            errorCellPhone.Visible = false;
            errorAddress.Visible = false;
            errorPwd.Visible = false;
            errorCheckPwd.Visible = false;
        }

        private void SetErrorLabel(System.Windows.Forms.Label errorLabel, string errorMessage)
        {
            errorLabel.Text = errorMessage;
            errorLabel.Visible = true;
        }

        //============驗證帳號是否重複
        //========1.Entity 寫法
        private bool IsAccountExists(string account)
        {
            // 檢查帳號是否已存在
            bool isAccountExists = dbContext.Shop_Member_Info.Any(p => p.Member_Account == account);

            // 回傳結果
            return isAccountExists;
        }


        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            //驗證使用者輸入的是否正確
            if (ValidateInputs())
            {
                try
                {
                    //MemberID - 時間撮timestamp
                    //var MemberID = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
                    //資料庫不吃 要改成nvchar

                    string Account = this.AccountText.Text;
                    string Name = this.NameText.Text;
                    string Gender = this.GenderComboBox.SelectedItem.ToString();

                    //string Birth = this.BirthDateTimePicker.Value.ToString("yyyy-MM-dd");

                    string Email = this.EmailText.Text;
                    string CellPhone = this.CellPhoneText.Text;
                    string Address = this.AddressText.Text;

                    //貓幣數量
                    int Discount = 0;
                    //紅利數量
                    int Bonus = 0;
                    //註冊時間
                    var SingUpTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    //密碼加密
                    string Password = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(this.PasswordText.Text, "sha1");

                    // 建立新的會員資料物件
                    Shop_Member_Info member = new Shop_Member_Info
                    {
                        Member_Account = Account,
                        Character_Name = "",
                        //Level_ID = 1,
                        Password = Password,
                        Name = Name,
                        Gender = Gender,
                        Birthday = BirthDateTimePicker.Value, // 資料庫 date 格式可以不用轉......直接傳value，DB會自動抓date
                        Email = Email,
                        Phone_Number = CellPhone,
                        Address = Address,
                        Cat_Coin_Quantity = Discount,
                        Loyalty_Points = Bonus,
                        Registration_Time = DateTime.Now,
                        //=================有在database 修改欄位的地方記得edmx也要重新整理(右鍵->從資料庫更新模型)
                        //Favorite_ID = 1
                    };
                    dbContext.Shop_Member_Info.Add(member);

                    // 儲存變更到資料庫
                    dbContext.SaveChanges();
                    // 將會員資料物件加入資料集合
                    MessageBox.Show("註冊成功！按下確定後到登入頁面。");

                    Signin form = new Signin();
                    form.ShowDialog();
                    this.Hide(); //視窗

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            AccountText.Text = "請輸入email";
            AccountText.ForeColor = Color.DarkGray;
        }

        private void AccountText_Enter(object sender, EventArgs e)
        {
            if (AccountText.Text == "請輸入email")
            {
                AccountText.Text = "";
                AccountText.ForeColor = Color.DarkGray;
            }
        }

        private void AccountText_Leave(object sender, EventArgs e)
        {
            if (AccountText.Text == "")
            {
                AccountText.Text = "請輸入email";
                AccountText.ForeColor = Color.DarkGray;
            }
        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {
            PasswordText.PasswordChar = '*'; //設定密碼顯示跟網頁一樣不顯示內容
        }

        private void CheckPwdText_TextChanged(object sender, EventArgs e)
        {
            CheckPwdText.PasswordChar = '*'; //設定密碼顯示跟網頁一樣不顯示內容
        }

        //private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    Signin form = new Signin();
        //    form.Show();
        //    this.Hide(); //關閉註冊的視窗
        //}
    }
    public class Person
    {
        public string Member_Account { get; set; }
        public string Character_Name { get; set; }
        public int Level_ID { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Phone_Number { get; set; }
        public string Address { get; set; }
        public string Cat_Coin_Quantity { get; set; }
        public string Loyalty_Points { get; set; }
        public DateTime Registration_Time { get; set; }
        public int Favorite_ID { get; set; }
    }
}
