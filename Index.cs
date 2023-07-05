using CatChaForms;
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
        public Index()
        {
            InitializeComponent();

            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(100, 180);
            pictureBox1.Size = new Size(350, 350);

            label2.Location = new Point(750, 820);


            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(-300, 50);
            pictureBox2.Size = new Size(350, 350);

            label1.Location = new Point(340, 680);

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
                //...........進入遊戲畫面
                MessageBox.Show("進入遊戲大廳");
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // 更改PictureBox的外觀或圖片，例如更換圖片或調整外觀屬性
            //pictureBox1.Image = Properties.Resources._startForm_paw__001_removebg_preview; // 按下時的圖片
            //pictureBox1.BorderStyle = BorderStyle.Fixed3D; // 使用3D效果的邊框樣式

            // 更改PictureBox的圖片和邊框樣式
            //pictureBox1.Image = Properties.Resources._startForm_paw__001_removebg_preview; // 按下時的圖片
            //pictureBox1.Paint += pictureBox1_Paint; // 訂閱Paint事件
            //pictureBox1.Invalidate(); // 強制PictureBox重新繪製
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // 繪製圓形邊框
            //Graphics g = e.Graphics;
            //g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // 抗鋸齒效果
            //Pen borderPen = new Pen(Color.Red, 2); // 邊框筆刷，這裡使用紅色
            //g.DrawEllipse(borderPen, 1, 1, pictureBox1.Width - 3, pictureBox1.Height - 3);
            //borderPen.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Shopping form = new Shopping();
            form.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // 触发pictureBox2 的 Click 事件
            pictureBox2_Click(pictureBox2, EventArgs.Empty);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // 触发 pictureBox1 的 Click 事件
            pictureBox1_Click(pictureBox1, EventArgs.Empty);
        }
    }
}
