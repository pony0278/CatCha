using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormResize;

namespace FormResize
{
    public partial class Frm_CatMove : BaseFormSetting
    {

       

        C_GameSetting gameSet = new C_GameSetting();

        //private int startLocationX;
        //private int startLocationY;

        int x = 0;
        int y = 0;
        //計數器，用來計算走路或停止了多久
        //int countWalk = 0;
        //int countStop = 0;
        //記錄當下走路的方向
        int directionX = 0;
        int directionY = 0;
        int second = 5;

        public Frm_CatMove()
        {
          
            InitializeComponent();
            
           
        }

        private void Frm_CatMove_Load(object sender, EventArgs e)
        {

            //貓位置初始設定
            //C_Cats._startPos(pic_Cat1, out startLocationX, out startLocationY);

            x = pic_Cat1.Location.X;
            y = pic_Cat1.Location.Y;
            
            //pic_Cat1.Location.X = new Point();

            //貓位置初始移動設定

            timer_CatWalk.Enabled = true;
            timer_CatWalk.Interval = 100;
            timer_CatWalk.Start();
            gameSet._MoveRange(out directionX, out directionY);
            if (directionX < 0)
            {
                pic_Cat1.Image = Properties.Resources.cat1_walkL;
            }
            else
                pic_Cat1.Image = Properties.Resources.cat1_walkR;
        }

        private void timer_CatWalk_Tick(object sender, EventArgs e)
        {

            if (gameSet.countWalk < gameSet._Period(second)) //走路狀態，且執行三秒
            {

                if (_TouchTopOrLeft())
                { 
                    gameSet.timerWalkStop(timer_CatStop, timer_CatWalk);
                    if (directionX > 0)
                    {
                        pic_Cat1.Image = Properties.Resources.cat1_stopR;
                    }
                    else
                        pic_Cat1.Image = Properties.Resources.cat1_stopL;
                    gameSet.countWalk = gameSet._Period(second);
                    x += 5;
                    y += 5;
                }

                else if (_TouchButtomOrRight())
                {       
                    gameSet.timerWalkStop(timer_CatStop, timer_CatWalk);
                    if (directionX > 0)
                    {
                        pic_Cat1.Image = Properties.Resources.cat1_stopR;
                    }
                    else
                        pic_Cat1.Image = Properties.Resources.cat1_stopL;
                    gameSet.countWalk = gameSet._Period(second);
                    x -= 10;
                    y -= 10;
                }
                else

                    x += directionX;
                y += directionY;
                pic_Cat1.Location = new Point(x, y);
                gameSet.countWalk += 1;
            }

            else
            {

                gameSet.timerWalkStop(timer_CatStop,timer_CatWalk);
                if (directionX > 0)
                {
                    pic_Cat1.Image = Properties.Resources.cat1_stopR;
                }
                else
                    pic_Cat1.Image = Properties.Resources.cat1_stopL;
            }

        }

        private void timer_CatStop_Tick(object sender, EventArgs e)
        {

            if (gameSet.countStop < gameSet._Period(3))
            {
                gameSet.countWalk = 0;
                gameSet.countStop += 1; 
            }

            else
            {
                gameSet.timerStopStop(timer_CatStop, timer_CatWalk);
                gameSet._MoveRange(out directionX, out directionY);
                if (directionX < 0)
                { pic_Cat1.Image = Properties.Resources.cat1_walkL; }
                else
                    pic_Cat1.Image = Properties.Resources.cat1_walkR;
            }
        }


        public bool _TouchTopOrLeft() //共用
        {
            return x <= 0 ||
                y <= 0;
        }
        public bool _TouchButtomOrRight() //共用
        {
            return
                x + pic_Cat1.Size.Width >= this.Width ||
                y + pic_Cat1.Size.Height >= this.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //C_Cats c = new C_Cats();
            //PictureBox p;

            //c._loadCat
            //    ("cat1",
            //    Properties.Resources.cat1_walkR,
            //    this,
            //    pic_Back,
            //    out p
            //    );
            //c._catMove(p, 
            //    Properties.Resources.cat1_walkR,
            //    Properties.Resources.cat1_walkL,
            //    Properties.Resources.cat1_stopL,
            //    Properties.Resources.cat1_stopR,
            //    this.Height,
            //    this.Width);
        }
    }
}
