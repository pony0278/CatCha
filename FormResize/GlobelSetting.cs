using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace FormResize
{
    public class GlobelSetting

        
    {

        C_Query q = new C_Query();
        //Frm_GameMain main = new Frm_GameMain();
        public static void _HIDEFORMCONTROL(Form f)  //置中新視窗+隱藏控制項+禁止使用者變動視窗大小
        {
            f.FormBorderStyle = FormBorderStyle.None;
            f.StartPosition = FormStartPosition.CenterScreen;
        }

        public static void _COVERWHITEVEIL(Form f) //TODO 新視窗出現時，原視窗蓋上半透明遮罩
        {
            Panel overlayPanel = new Panel(); 
            overlayPanel.BackColor = Color.FromArgb(80,255,255,255);
            overlayPanel.Width = f.Width;
            overlayPanel.Height = 1000;
            overlayPanel.Dock = DockStyle.Fill;
            overlayPanel.BringToFront();
            overlayPanel.TabIndex = 0;
            f.Controls.Add(overlayPanel);
        }

        //public static void _LETTEXTPARENTED(Form f)
        //{
        //    foreach (Label l in f.Controls.OfType<Label>().Where(l => l.Tag.ToString().Contains("btn")))
        //    {
        //        foreach (PictureBox p in f.Controls.OfType<PictureBox>().Where(p => p.Tag.ToString().Contains("btn") && p.Tag.ToString() == l.Tag.ToString()))
        //        {
        //            { l.Parent = p; }
        //        }     
        //    }
        //}

        public static void _LETTEXTPARENTED(Form f)
        {
            foreach (Label l in f.Controls.OfType<Label>().Where(l => l.Tag.ToString().Contains("btn")))
            {
                foreach (PictureBox p in f.Controls.OfType<PictureBox>().Where(p => p.Tag.ToString().Contains("btn") && p.Tag.ToString() == l.Tag.ToString()))
                {
                    l.Parent = p;
                }
            }
        }
        public static void _POPFORMTOCENTER(Form original,Form f) //讓新視窗出現在原是窗位置的中間
        {
            f.StartPosition = FormStartPosition.Manual;

            // 計算新表單的位置，使其位於原表單的畫面中央
            int newX = original.Location.X + (original.Width - f.Width) / 2;
            int newY = original.Location.Y + (original.Height - f.Height) / 2;
            f.Location = new Point(newX, newY);

        }

        public static void _RATIOFIXED(Form f)  //固定視窗比例
        {
            //設定初始比例
            const int targetWidth = 1500;
            const int targetHeight = 1000;
            //計算現在視窗比例
            float currentAspectRatio = (float)f.Width / f.Height;
            float targetAspectRatio = (float)targetWidth / targetHeight;

            //當視窗比例被更動的時候
            if (currentAspectRatio != targetAspectRatio)
            {
                // 計算被變動的尺寸是否符合原始設定尺寸比例
                int newWidth = f.Width;
                int newHeight = f.Height;

                //當被變動的時候，強制將視窗縮回固定大小
                if (currentAspectRatio > targetAspectRatio|| currentAspectRatio < targetAspectRatio)
                {
                    newWidth = (int)(newHeight * targetAspectRatio);
                }
                else
                {
                    newHeight = (int)(newWidth / targetAspectRatio);
                }

                //重新設定
                f.Size = new Size(newWidth, newHeight);
            }
        }


        public void _SAVECAT() //TODO 把main的產生貓咪方法寫過來
        {
            //Frm_GameMain main = new Frm_GameMain();
            //if (Properties.Settings.Default.catG_Exist == true)
            //{
            //    main.create_Cat_g();

            //}
            //if (Properties.Settings.Default.catY_Exist == true)
            //{
            //    main.create_Cat_y();

            //}
            //if (Properties.Settings.Default.catW_Exist == true)
            //{
            //    main.create_Cat_w();

            //}
        }

        public void _REFRESHCCoin(Label label)
        {
            貓抓抓Entities2 db = new 貓抓抓Entities2();
            var qCoinRefresh = db.Shop_Member_Info.Where(n => n.Member_Account == q.MemberAccount).Select(n => n.Cat_Coin_Quantity);
            label.Text = qCoinRefresh.FirstOrDefault().ToString();
        }

        public void _REFRESHRuby(Label label)
        {
            貓抓抓Entities2 db = new 貓抓抓Entities2();
            var qCoinRefresh = db.Shop_Member_Info.Where(n => n.Member_Account == q.MemberAccount).Select(n => n.Loyalty_Points);
            label.Text = qCoinRefresh.FirstOrDefault().ToString();
        }


        public void _ConsumeCCoin(int i) //扭蛋消耗貓幣
        {
            貓抓抓Entities2 db = new 貓抓抓Entities2();
            var consumeCCoin = db.Shop_Member_Info.FirstOrDefault(n => n.Member_Account == q.MemberAccount);
            if (consumeCCoin != null)
            {
                consumeCCoin.Cat_Coin_Quantity -= 500*i;
                db.SaveChanges();
            }
        }
        public void _ConsumeRuby(int i) //扭蛋消耗紅利
        {
            貓抓抓Entities2 db = new 貓抓抓Entities2();
            var consumeRuby = db.Shop_Member_Info.FirstOrDefault(n => n.Member_Account == q.MemberAccount);
            if (consumeRuby != null)
            {
                consumeRuby.Loyalty_Points -= 100 * i;
                db.SaveChanges();
            }
        }

        public int CCoinCheckBeforeDraw() 
        {
            貓抓抓Entities2 db = new 貓抓抓Entities2();
            var qCatCoin = from n in db.Shop_Member_Info where n.Member_Account == q.MemberAccount select n.Cat_Coin_Quantity;
            return (int)qCatCoin.FirstOrDefault();
        }
        public int RubyCheckBeforeDraw()
        {
            貓抓抓Entities2 db = new 貓抓抓Entities2();
            var qRuby = from n in db.Shop_Member_Info where n.Member_Account == q.MemberAccount select n.Loyalty_Points;
            return (int)qRuby.FirstOrDefault();
        }

    }
}
