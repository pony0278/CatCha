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
using CatCaha.Properties;

namespace FormResize
{
    public partial class Frm_BackGroundPack : Form
    {
        private Frm_GameMain mainForm;
        C_BackPic bg;
        public Frm_BackGroundPack(Frm_GameMain ParentForm)
        {
            bg = new C_BackPic();
            mainForm = ParentForm;
            InitializeComponent();
            GlobelSetting._HIDEFORMCONTROL(this);
            bg._startLoad(this);
        }

        
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_1_Click(object sender, EventArgs e)
        {
            pic_Main.Image = this.pic_1.Image;
            this.btn_Ok.Tag = "Default";
            txt_BGTitle.Text = "溫馨小房間";
            txt_Descibe.Text = "貓抓抓給玩家的基本背景";
        }

        private void pic_2_Click(object sender, EventArgs e)
        {
            pic_Main.Image = this.pic_2.Image;
             this.btn_Ok.Tag = "backPic2";
            txt_BGTitle.Text = "大電視房間";
            txt_Descibe.Text = "復古電視跟可愛的房間有點不搭......";
        }

        private void pic_3_Click(object sender, EventArgs e)
        {
            pic_Main.Image = this.pic_3.Image;
            this.btn_Ok.Tag = "backPic3";
            txt_BGTitle.Text = "大沙發房間";
            txt_Descibe.Text = "沙發上面都是貓的抓痕";
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            mainForm.BackgroundImage = pic_Main.Image;
            CatCaha.Properties.Settings.Default.backPic = (string)btn_Ok.Tag;
            CatCaha.Properties.Settings.Default.Save();    
        }
    }
}
