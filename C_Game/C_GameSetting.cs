using FormResize.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormResize
{
    public class C_GameSetting
    {
        Frm_GameMain main;
        GlobelSetting setting = new GlobelSetting();
      
        C_Backpack package = new C_Backpack();

        PictureBox p = null;

        //TODO 把放置貓的功能改到這裡 再給form呼叫
        //public void _checkCatStatus(Form f,PictureBox p)
        //{
        //    if (Settings.Default.catG_Exist == true)
        //    {
        //        package.create_Cat_g(f, p);
        //    }
        //    if (Settings.Default.catY_Exist == true)
        //    {
        //        package.create_Cat_y(f, p);
        //    }
        //    if (Settings.Default.catW_Exist == true)
        //    {
        //        package.create_Cat_w(f, p);
        //    }
        //}

        //===============

        Random ran = new Random();


        public int formWidth(Form r)
        {
            return r.Width;
        }

        public int formHeight(Form r)
        {
            return r.Height;
        }

        //計數器，用來計算走路或停止了多久
        public int countWalk = 0;
        public int countStop = 0;

        public int _Period(int x)
        {
            return x * 10;
        }//填入動作要進行的秒數

        private int XMovePeriod(int min, int max)
        {
            return ran.Next(min, max + 1);
        }

        private int YMovePeriod(int min, int max)
        {
            return ran.Next(min, max + 1);
        }
        private int XMoveRange(int min, int max)
        {
            return ran.Next(min, max + 1);
        }//Private隨機產生範圍內移動的x距離

        private int YMoveRange(int min, int max)
        {
            return ran.Next(min, max + 1);
        }//Privat隨機產生範圍內移動的y距離


        public int XStartPos()
        {
            return ran.Next(0,1500);
        }
        public int YStartPos()
        {
            return ran.Next(50, 100);
        }
        public void _MoveRange(out int x, out int y)//傳給form使用
        {
            x = XMoveRange(-5, 5);
            y = YMoveRange(-1, 1);
        }
        public void _MovePeriod(out int x, out int y)//傳給form使用
        {
            x = XMovePeriod(3, 10);
            y = YMovePeriod(1, 3);
        }


        public void timerStopStop(Timer s, Timer w) //停止解除，走路開始
        {
            s.Stop();
            w.Enabled = true;
            w.Interval = 100;
            countWalk = 0;
            w.Start();
        }

        public void timerWalkStop(Timer s, Timer w) //走路解除，停止開始
        {
            w.Stop();
            s.Enabled = true;
            s.Interval = 100;
            countStop = 0;
            s.Start();
        }

        
        

    }
}
