using FormResize.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using 抽卡;

namespace FormResize
{

    public partial class Frm_GameMain : Form
    {

        C_Query q = new C_Query();
        C_Cats cat_g;
        C_Cats cat_y;
        C_Cats cat_w;
        private float x;//定義當前窗體的寬度
        private float y;//定義當前窗體的高度
        public int _ChangedHeightForCats ;
        public int _ChangedWidthForCats;
        public Frm_GameMain()
        {
            InitializeComponent();

            //載入遊戲名稱
            txt_ID.Text = q._GameName();
            //載入貓幣金額
            txt_CatCoin.Text = q._GameCatCoin();
            //載入紅利金額
            txt_RedStone.Text = q._GameRLPoint();


            //x = this.Width;
            //y = this.Height;
            //setTag(this);

            //載入時判斷是否放出貓咪
            if (Settings.Default.catG_Exist == true)
            {
                this.create_Cat_g();

            }
            if (Settings.Default.catY_Exist == true)
            {
                this.create_Cat_y();

            }
            if (Settings.Default.catW_Exist == true)
            {
                this.create_Cat_w();

            }
        }

        //=======================
        //public void setTag(Control cons)
        //{
        //    foreach (Control con in cons.Controls)
        //    {
        //        con.Tag = con.Width + ";" + con.Height + ";" + con.Left + ";" + con.Top + ";" + con.Font.Size;
        //        if (con.Controls.Count > 0)
        //        {
        //            setTag(con);
        //        }
        //    }
        //}

        //private void setControls(float newx, float newy, Control cons)
        //{
        //    //遍歷窗體中的控件，重新設置控件的值
        //    foreach (Control con in cons.Controls)
        //    {
        //        //獲取控件的Tag屬性值，並分割後存儲字符串數組
        //        if (con.Tag != null)
        //        {
        //            string[] mytag = con.Tag.ToString().Split(new char[] { ';' });
        //            //根據窗體縮放的比例確定控件的值
        //            con.Width = Convert.ToInt32(Convert.ToSingle(mytag[0]) * newx);//寬度
        //            con.Height = Convert.ToInt32(Convert.ToSingle(mytag[1]) * newy);//高度
        //            con.Left = Convert.ToInt32(Convert.ToSingle(mytag[2]) * newx);//左邊距
        //            con.Top = Convert.ToInt32(Convert.ToSingle(mytag[3]) * newy);//頂邊距
        //            Single currentSize = Convert.ToSingle(mytag[4]) * newy;//字體大小
        //            con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
        //            if (con.Controls.Count > 0)
        //            {
        //                setControls(newx, newy, con);
        //            }
        //        }
        //    }
        //}

        private void BaseFormSetting_Resize(object sender, EventArgs e)
        {
            //float newx = (this.Width) / x;
            //float newy = (this.Height) / y;
            //setControls(newx, newy, this);
        }

        private void BaseFormSetting_Load(object sender, EventArgs e) //設定視窗開啟時的尺寸
        {
            txt_GameShop.Parent = pic_Pow_GameShop;
            txt_CatchaShop.Parent = pic_Pow_CatchaShop;
            txt_Gatcha.Parent = pic_Pow_Gatcha;
            txt_BG.Parent = pic_Pow_BG;
            txt_BackPack.Parent = pic_Pow_BackPack;
            txt_ID.Parent = pic_NameUI;
            //GlobelSetting._LETTEXTPARENTED(this);

            //TODO 不能是空白背景

            this.BackgroundImage = Resources.background_default;
            //TODO 處理載入setting 圖片問題 載入上次更換的圖片
            switch (Settings.Default.backPic)
            {
                case "Default":
                    this.BackgroundImage = Resources.background_default;
                    break;
                case "backPic2":
                    this.BackgroundImage = Resources.background_02;
                    break;
                case "backPic3":
                    this.BackgroundImage = Resources.background_03;
                    break;
                   
                    
            }

            //this.BackgroundImage = Image.FromFile(bg);

        }

        private void BaseFormSetting_SizeChanged(object sender, EventArgs e) //設定視窗只能按照比例縮放
        {
            GlobelSetting._RATIOFIXED(this);
            _ChangedHeightForCats = this.panel1.Height;
            _ChangedWidthForCats = this.panel1.Width;
        }

        private void btn_BackGround_Click(object sender, EventArgs e) //背景更換
        {
            Frm_BackGroundPack frm_BackGroundPack = new Frm_BackGroundPack(this);
            //C_GlobelSetting._COVERWHITEVEIL(this);
            GlobelSetting._POPFORMTOCENTER(this, frm_BackGroundPack);

            frm_BackGroundPack.ShowDialog();//開啟更換背景視窗
        }

      
        //給背包呼叫貓咪用的方法
        PictureBox p = null;
        PictureBox p2 = null;
        PictureBox p3 = null;
        public void create_Cat_g()
        {
            cat_g = new C_Cats();
            if (p2 != null)
            {
                Controls.Remove(p2);
                p2.Dispose();
                p2 = null;
                Settings.Default.catG_Exist = false;
                Settings.Default.Save();
            }
            else
            {
                cat_g._loadCat
                    ("cat1",
                    Resources.cat_g_wR,
                    this,
                    pic_Back,
                    out p2
                    );
                cat_g._catMove(p2,
                    Resources.cat_g_wR,
                    Resources.cat_g_wL,
                    Resources.cat_g_sR,
                    Resources.cat_g_sL,
                    panel1.Location.Y+100 ,
                   1500);

                Settings.Default.catG_Exist = true;
                Settings.Default.Save();
            }
        }
        public void create_Cat_y()
        {
            cat_y = new C_Cats();
            if (p != null)
            {
                Controls.Remove(p);
                p.Dispose();
                p = null;
                Settings.Default.catY_Exist = false;
                Settings.Default.Save();
            }
            else
            {
                cat_y._loadCat
                    ("cat1",
                    Properties.Resources.cat_y_wR,
                    this,
                    pic_Back,
                    out p
                    );
                cat_y._catMove(p,
                    Properties.Resources.cat_y_wR,
                    Properties.Resources.cat_y_wL,
                    Properties.Resources.cat_y_sR,
                    Properties.Resources.cat_y_sL,
                    panel1.Location.Y + 100,
                   1500);

                Settings.Default.catY_Exist = true;
                Settings.Default.Save();
            }
        }
        public void create_Cat_w()
        {
            cat_w = new C_Cats();
            if (p3 != null)
            {
                Controls.Remove(p3);
                p3.Dispose();
                p3 = null;
                Settings.Default.catW_Exist = false;
                Settings.Default.Save();

            }
            else
            {
                cat_w._loadCat
                ("cat2",
                Resources.cat_w_wR,
                this,
                pic_Back,
                out p3
                );
                cat_w._catMove(p3,
                    Resources.cat_w_wR,
                    Resources.cat_w_wL,
                    Resources.cat_w_sR,
                    Resources.cat_w_sL,
                   panel1.Location.Y + 100,
                   1500);
                Settings.Default.catW_Exist = true;
                Settings.Default.Save();
            }
        }

       

        private void txt_CatCoin_Click(object sender, EventArgs e)
        {

        }

        private void pic_Bell_Click(object sender, EventArgs e)
        {
            Frm_Notify frm_Notify = new Frm_Notify(this);
            //GlobelSetting._COVERWHITEVEIL(this);
            GlobelSetting._POPFORMTOCENTER(this, frm_Notify);
            frm_Notify.ShowDialog();
        }

        private void pic_CheckIn_Click(object sender, EventArgs e)
        {
            Frm_Achievement frm_Achievement = new Frm_Achievement(this);
            //C_GlobelSetting._COVERWHITEVEIL(this);
            GlobelSetting._POPFORMTOCENTER(this, frm_Achievement);

            frm_Achievement.ShowDialog();
        }


        private void panel_BackPack_Click(object sender, EventArgs e)
        {
            Frm_Backpack frm_Backage = new Frm_Backpack(this);
            //C_GlobelSetting._COVERWHITEVEIL(this);
            GlobelSetting._POPFORMTOCENTER(this, frm_Backage);

            frm_Backage.ShowDialog();
        }

        private void txt_GameShop_Click(object sender, EventArgs e)
        {

        }

        private void txt_BackPack_Click(object sender, EventArgs e)
        {
            Frm_Backpack frm_Backage = new Frm_Backpack(this);
            //C_GlobelSetting._COVERWHITEVEIL(this);
            GlobelSetting._POPFORMTOCENTER(this, frm_Backage);

            frm_Backage.ShowDialog();
        }

        private void txt_BG_Click(object sender, EventArgs e)
        {
            Frm_BackGroundPack frm_BackGroundPack = new Frm_BackGroundPack(this);
            //C_GlobelSetting._COVERWHITEVEIL(this);
            GlobelSetting._POPFORMTOCENTER(this, frm_BackGroundPack);

            frm_BackGroundPack.ShowDialog();//開啟更換背景視窗
        }

        private void txt_Gatcha_Click(object sender, EventArgs e)
        {
            Frm_Summon frm_Summon = new Frm_Summon(this);
            GlobelSetting._POPFORMTOCENTER(this, frm_Summon);
            frm_Summon.ShowDialog();
        }

        private void txt_CatchaShop_Click(object sender, EventArgs e)
        {

        }

        private void txt_ID_Click(object sender, EventArgs e)
        {

        }

        
    }
}


