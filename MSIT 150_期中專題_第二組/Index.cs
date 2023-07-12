using CatChaForms;
using FormResize;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatCaha
{
    public partial class Index : Form
    {
        Frm_GameMain main = new Frm_GameMain();
        C_Query q = new C_Query();
        public Index()
        {
            InitializeComponent();

            // 修改PictureBox的尺寸
            //pictureBox1.Size = new Size(300, 300);

            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(200, 250);
            pictureBox1.Size = new Size(450, 450);

            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(-250, 150);
            pictureBox2.Size = new Size(470, 470);

            //================圖片旋轉
            Image blue_paw = pictureBox1.Image;
            Graphics graphic1 = Graphics.FromImage(blue_paw);
            graphic1.RotateTransform(45);

            Image pink_paw = pictureBox2.Image;
            Graphics graphic2 = Graphics.FromImage(pink_paw);
            graphic2.RotateTransform(-20);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (LoggedInUser.Username == null && LoggedInUser.ID == 0)
            {
                MessageBox.Show("請先登入");
                Signin form = new Signin();
                form.ShowDialog();
            }
            else
            {
                if (main == null || main.IsDisposed)
                {
                    main = new Frm_GameMain();
                }
                string GameName = LoggedInUser.Username;
                int MemberID = LoggedInUser.ID;
                GameName = MemberID.ToString();
                //...........進入遊戲畫面
                //MessageBox.Show("進入遊戲大廳");
                main.Show();
                //載入遊戲名稱
                main.txt_ID.Text = q._GameName().ToString();
                //載入貓幣金額
                main.txt_CatCoin.Text = q._GameCatCoin();
                //載入紅利金額
                main.txt_RedStone.Text = q._GameRLPoint();
            }
        }

        //private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    // 更改PictureBox的外觀或圖片，例如更換圖片或調整外觀屬性
        //    //pictureBox1.Image = Properties.Resources._startForm_paw__001_removebg_preview; // 按下時的圖片
        //    //pictureBox1.BorderStyle = BorderStyle.Fixed3D; // 使用3D效果的邊框樣式

        //    // 更改PictureBox的圖片和邊框樣式
        //    pictureBox1.Image = Properties.Resources._startForm_paw__001_removebg_preview; // 按下時的圖片
        //    pictureBox1.Paint += pictureBox1_Paint; // 訂閱Paint事件
        //    pictureBox1.Invalidate(); // 強制PictureBox重新繪製
        //}

        //private void pictureBox1_Paint(object sender, PaintEventArgs e)
        //{
        //    // 繪製圓形邊框
        //    Graphics g = e.Graphics;
        //    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // 抗鋸齒效果
        //    Pen borderPen = new Pen(Color.Red, 2); // 邊框筆刷，這裡使用紅色
        //    g.DrawEllipse(borderPen, 1, 1, pictureBox1.Width - 3, pictureBox1.Height - 3);
        //    borderPen.Dispose();
        //}

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Shopping form = new Shopping();
            form.Show();
            //this.Hide();
        }
    }
}
