using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FormResize
{
    public class C_Cats
    {
      
        C_GameSetting setting = new C_GameSetting();
        Random ran = new Random();

        public void _catMove(PictureBox p, Image wR, Image wL, Image sR, Image sL,int h, int w)
        {
            setting = new C_GameSetting();
            int x = 0;
            int y = 0;
            int directionX = 0;
            int directionY = 0;
            int walkSecond = 10;
            
            catMove();
            void catMove()
            {
                //timer設置
                Timer TimerS = new Timer();
                Timer TimerW = new Timer();
                TimerS.Interval = 1000;
                TimerS.Tick += new EventHandler(TimerS_Tick);
                TimerW.Interval = 1000;
                TimerW.Tick += new EventHandler(TimerW_Tick);


                x = p.Location.X;
                y = p.Location.Y;
                
               

                //貓位置初始移動設定

                TimerW.Enabled = true;
                TimerW.Interval = 100;
                TimerW.Start();
                setting._MoveRange(out directionX, out directionY);
                if (directionX < 0)
                {
                    p.Image = wL;
                }
                else
                    p.Image = wR;

                void TimerS_Tick(object sender, EventArgs e)
                {
                    //p.BringToFront();
                    if (setting.countStop < setting._Period(3))
                    {
                        setting.countWalk = 0;
                        setting.countStop += 1;
                    }

                    else
                    {
                        setting.timerStopStop(TimerS, TimerW);
                        setting._MoveRange(out directionX, out directionY);
                        if (directionX < 0)
                        { p.Image = wL; }
                        else
                            p.Image = wR;
                    }
                }
                void TimerW_Tick(object sender, EventArgs e)
                {
                    //p.BringToFront();
                    if (setting.countWalk < setting._Period(walkSecond)) //走路狀態，且執行5秒
                    {

                        if (TouchTopOrLeft())
                        {
                            setting.timerWalkStop(TimerS, TimerW);
                            if (directionX > 0)
                            {
                                p.Image = sR;
                            }
                            else
                                p.Image = sL;
                            setting.countWalk = setting._Period(walkSecond);
                            x += 5;
                            y += 5;
                        }

                        else if (TouchButtomOrRight())
                        {
                            setting.timerWalkStop(TimerS, TimerW);
                            if (directionX > 0)
                            {
                                p.Image = sR;
                            }
                            else
                                p.Image = sL;
                            setting.countWalk = setting._Period(walkSecond);
                            x -= 10;
                            y -= 10;
                        }
                        else

                            x += directionX;
                        y += directionY;
                        p.Location = new Point(x, y);
                        setting.countWalk += 1;
                    }

                    else
                    {

                        setting.timerWalkStop(TimerS, TimerW);
                        if (directionX > 0)
                        {
                            p.Image = sR;
                        }
                        else
                            p.Image = sL;
                    }
                }
            }
            bool TouchTopOrLeft() //共用
            {
                return x <= 0 ||
                    y <= 0;
            }
            bool TouchButtomOrRight() //共用
            {
                return
                    x  >= w||
                    y  >= h;
            }
        }//貓咪移動方式
         //共八個參數： 實作pictureBox名稱、走路(右邊)gif、走路(左邊)gif、靜止(右邊)gif、靜止(左邊)gif、限制範圍(高)、限制範圍(寬)

        public void _loadCat(string name,Image i,Form f, PictureBox back, out PictureBox cat1) //創造貓咪圖片
        {
            //建立一個pictureBox
            cat1 = new PictureBox();
            cat1.Anchor =((AnchorStyles.Bottom | AnchorStyles.Left));
            cat1.BackColor = Color.Transparent;
            cat1.Image = i; //初始圖片路徑;
            cat1.Location = new Point(setting.XStartPos(), setting.YStartPos());
            cat1.Margin = new Padding(0, 1, 0, 1);
            cat1.Name = name;
            cat1.Size = new Size(120, 120);
            cat1.SizeMode = PictureBoxSizeMode.StretchImage;
            cat1.TabIndex = 0;
            cat1.TabStop = false;
            f.Controls.Add(cat1);
            cat1.Parent = back;    
        }
        //共五個參數：貓咪名字、初始貓咪圖、Form名稱、背景圖片名稱、實作pictureBox名稱


        //TODO 限制貓咪移動範圍
        //TODO 限制貓咪不要碰撞?
        public void _loadCat_withoutBack(string name, Image i, Form f, out PictureBox cat1) //創造貓咪圖片
        {
            //建立一個pictureBox
            cat1 = new PictureBox();
            cat1.Anchor = ((AnchorStyles.Bottom | AnchorStyles.Left));
            cat1.BackColor = Color.Transparent;
            cat1.Image = i; //初始圖片路徑;
            cat1.Location = new Point(100, 100);
            cat1.Margin = new Padding(0, 1, 0, 1);
            cat1.Name = name;
            cat1.Size = new Size(120, 120);
            cat1.SizeMode = PictureBoxSizeMode.StretchImage;
            cat1.TabIndex = 0;
            cat1.TabStop = false;
            f.Controls.Add(cat1);
            
        }
    }
}
