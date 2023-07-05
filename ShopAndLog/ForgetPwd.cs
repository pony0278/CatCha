using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using CatCaha.NewFolder1;

namespace CatChaForms
{
    public partial class ForgetPwd : Form
    {
        project123Entities dbContext = new project123Entities();
        public ForgetPwd()
        {
            InitializeComponent();
            UpdateVerifyCode(); //生成驗證碼
        }

        static public string userAcc;//全域變數
        //驗證碼的長度
        private const int iVerifyCodeLength = 6;

        //驗證碼
        private String strVerifyCode = "";

        //匹配字符的臨時變數
        string strTemp = "";

        //更新驗證碼
        private void UpdateVerifyCode()
        {
            strVerifyCode = CreateRandomCode(iVerifyCodeLength);

            if (strVerifyCode == "")
            {
                return;
            }

            strTemp = strVerifyCode;
            CreateImage(strVerifyCode);
        }

        //生成驗證碼字符串
        private string CreateRandomCode(int iLength)
        {
            int rand;
            char code;
            string randomCode = String.Empty;

            //生成一定長度的驗證碼
            System.Random random = new Random();

            for (int i = 0; i < iLength; i++)
            {
                rand = random.Next();

                if (rand % 3 == 0)
                {
                    code = (char)('A' + (char)(rand % 26));
                }
                else
                {
                    code = (char)('0' + (char)(rand % 10));
                }
                randomCode += code.ToString();
            }
            return randomCode;
        }

        // 創建驗證碼圖片
        private void CreateImage(string strVerifyCode)
        {
            try
            {
                int iRandAngle = 45;    //隨機轉動角度
                int iMapWidth = (int)(strVerifyCode.Length * 21);
                Bitmap map = new Bitmap(iMapWidth, 28);    //創建圖片背景
                Graphics graph = Graphics.FromImage(map);
                graph.Clear(Color.AliceBlue);//清除畫面，填充背景
                graph.DrawRectangle(new Pen(Color.Black, 0), 0, 0, map.Width - 1, map.Height - 1);//畫一個邊框
                graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//模式
                Random rand = new Random();

                //背景噪點生成
                Pen blackPen = new Pen(Color.LightGray, 0);
                for (int i = 0; i < 50; i++)
                {
                    int x = rand.Next(0, map.Width);
                    int y = rand.Next(0, map.Height);
                    graph.DrawRectangle(blackPen, x, y, 1, 1);
                }

                //驗證碼旋轉，防止機器識別
                char[] chars = strVerifyCode.ToCharArray();//拆散字符串成单字符数组

                //文字距中
                StringFormat format = new StringFormat(StringFormatFlags.NoClip);

                format.Alignment = StringAlignment.Center;

                format.LineAlignment = StringAlignment.Center;

                //定義顏色
                Color[] c = { Color.Black, Color.Red, Color.DarkBlue, Color.Green, Color.Orange, Color.Brown, Color.DarkCyan, Color.Purple };

                //定義字體
                string[] font = { "Verdana", "Microsoft Sans Serif", "Comic Sans MS", "Arial", "宋体" };

                for (int i = 0; i < chars.Length; i++)
                {
                    int cindex = rand.Next(7);
                    int findex = rand.Next(5); Font f = new System.Drawing.Font(font[findex], 13, System.Drawing.FontStyle.Bold);//字體樣式(參數2為字體大小)
                    Brush b = new System.Drawing.SolidBrush(c[cindex]);
                    Point dot = new Point(16, 16);
                    float angle = rand.Next(-iRandAngle, iRandAngle);//轉動的度數
                    graph.TranslateTransform(dot.X, dot.Y);//移動光標到指定位置
                    graph.RotateTransform(angle);
                    graph.DrawString(chars[i].ToString(), f, b, 1, 1, format);
                    graph.RotateTransform(-angle);//轉回去
                    graph.TranslateTransform(2, -dot.Y);//移動光標到指定位置
                }
                pictureBox1.Image = map;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("創建圖片發生錯誤，請再試一次");
            }
        }

        private void ChangeImg_Click(object sender, EventArgs e)
        {
            //換別張
            UpdateVerifyCode();
        }

        private bool checkTextBox()
        {
            ClearErrorLabels(); // 清除之前的錯誤消息
            bool check = true; //默認為true

            //異常檢測
            if (txtAccount.Text.Trim() == "")
            {
                SetErrorLabel(ForgetMsg, "請輸入帳號");
                check = false;
            }
            else if (textBox1.Text.Trim() == "")
            {
                SetErrorLabel(ForgetMsg, "請輸入驗證碼");
                check = false;
            }
            return check;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // 帳號
            string loginAcc = txtAccount.Text;

            if (checkTextBox())
            {
                try
                {
                    Shop_Member_Info user = dbContext.Shop_Member_Info.FirstOrDefault(u => u.Member_Account == loginAcc);
                    //=================不驗證大小寫
                    if (textBox1.Text.ToLower() == strTemp.ToLower())
                    {
                        // 驗證是否有此會員
                        if (user != null)
                        {
                            userAcc = loginAcc; //全域變數紀錄使用者帳號
                            ChangePwd form = new ChangePwd();
                            form.ShowDialog();
                            this.Hide(); //關閉視窗
                        }
                        else
                        {
                            SetErrorLabel(ForgetMsg, "此帳號不存在，請重新輸入");
                        }
                    }
                    else
                    {
                        SetErrorLabel(ForgetMsg, "驗證碼錯誤，請重新輸入");
                        UpdateVerifyCode();
                        textBox1.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ClearErrorLabels()
        {
            ForgetMsg.Visible = false;
        }

        private void SetErrorLabel(System.Windows.Forms.Label errorLabel, string errorMessage)
        {
            errorLabel.Text = errorMessage;
            errorLabel.Visible = true;
        }
    }
}
