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

namespace FormResize
{
    public partial class Frm_Backpack : Form
    {
       private Frm_GameMain mainForm;
        C_GameSetting setting;
        C_Backpack p;
        public Frm_Backpack(Frm_GameMain ParentForm)
        {
            InitializeComponent();
            GlobelSetting._HIDEFORMCONTROL(this);
            mainForm = ParentForm;
            setting = new C_GameSetting();
            p = new C_Backpack();

            p._startLoad(this);



            //======測試用
            addCat1(); //開啟背包時載入資料
        }

        List<int> pets = new List<int> { 1, 2, 3 };

        //先抓取使用者資料庫背包裡面的物品
        //根據日期排序放到List裡面
        //製作圖片版型
        //每一個東西對應一個編號，編號對應圖片，foreach加到背包裡面
        public void addCat1() 
        {
            this.pic_Item1.Image = Resources.cat_pic2;
            this.pic_Item2.Image = Resources.cat_pic3;
        }
       
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        //TODO 個別物品欄之後改成，當有商品寫入的時候，才去註冊click方法

        private void pic_Item1_Click(object sender, EventArgs e)
        {
            mainForm.create_Cat_y();
            
        }

        private void pic_Item2_Click(object sender, EventArgs e)
        {
            mainForm.create_Cat_w();
        }

        private void pic_Item3_Click(object sender, EventArgs e)
        {
            mainForm.create_Cat_g();
        }

        private void pic_Item4_Click(object sender, EventArgs e)
        {

        }
        private void btn_All_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_All.Visible = true;
            flowLayoutPanel_Pet.Visible = false;
            flowLayoutPanel_Item.Visible = false;
        }
        private void btn_MyPet_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_All.Visible = false;
            flowLayoutPanel_Pet.Visible = true;
            flowLayoutPanel_Item.Visible = false;
        }

        private void btn_Items_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_All.Visible = false;
            flowLayoutPanel_Pet.Visible = false;
            flowLayoutPanel_Item.Visible = true;
        }
    }
}
