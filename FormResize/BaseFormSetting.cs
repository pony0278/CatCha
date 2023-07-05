using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormResize
{
    public partial class BaseFormSetting : Form
    {
        private float x;//定義當前窗體的寬度
        private float y;//定義當前窗體的高度
        public BaseFormSetting()
        {
            InitializeComponent();
            x = this.Width;
            y = this.Height;
            setTag(this);


        }
        private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ";" + con.Height + ";" + con.Left + ";" + con.Top + ";" + con.Font.Size;
                if (con.Controls.Count > 0)
                {
                    setTag(con);
                }
            }
        }

        private void setControls(float newx, float newy, Control cons)
        {
            //遍歷窗體中的控件，重新設置控件的值
            foreach (Control con in cons.Controls)
            {
                //獲取控件的Tag屬性值，並分割後存儲字符串數組
                if (con.Tag != null)
                {
                    string[] mytag = con.Tag.ToString().Split(new char[] { ';' });
                    //根據窗體縮放的比例確定控件的值
                    con.Width = Convert.ToInt32(Convert.ToSingle(mytag[0]) * newx);//寬度
                    con.Height = Convert.ToInt32(Convert.ToSingle(mytag[1]) * newy);//高度
                    con.Left = Convert.ToInt32(Convert.ToSingle(mytag[2]) * newx);//左邊距
                    con.Top = Convert.ToInt32(Convert.ToSingle(mytag[3]) * newy);//頂邊距
                    Single currentSize = Convert.ToSingle(mytag[4]) * newy;//字體大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                    if (con.Controls.Count > 0)
                    {
                        setControls(newx, newy, con);
                    }
                }
            }
        }

        private void BaseFormSetting_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / x;
            float newy = (this.Height) / y;

            setControls(newx, newy, this);


        }

        private void BaseFormSetting_Load(object sender, EventArgs e) //設定視窗開啟時的尺寸
        {
            this.Size = new Size(1440, 900);





        }

        private void BaseFormSetting_SizeChanged(object sender, EventArgs e) //設定視窗只能按照比例縮放
        {
            //設定初始比例
            const int targetWidth = 1440;
            const int targetHeight = 900;
            // Calculate the aspect ratio of the current window
            float currentAspectRatio = (float)this.Width / this.Height;
            float targetAspectRatio = (float)targetWidth / targetHeight;

            //當視窗比例被更動的時候
            if (currentAspectRatio != targetAspectRatio)
            {
                // 計算被變動的尺寸是否符合原始設定尺寸比例
                int newWidth = this.Width;
                int newHeight = this.Height;

                //當被變動的時候，強制將視窗縮回固定大小
                if (currentAspectRatio > targetAspectRatio)
                {
                    newWidth = (int)(newHeight * targetAspectRatio);
                }
                else
                {
                    newHeight = (int)(newWidth / targetAspectRatio);
                }

                //重新設定
                this.Size = new Size(newWidth, newHeight);
            }

        }


    }    
    
}
    

