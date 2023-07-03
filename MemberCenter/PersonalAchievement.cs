using CatCaha;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace LinqLabs
{
    public partial class PersonalAchievement : Form
    {

        public PersonalAchievement(int data)
        {
            InitializeComponent();

            now_Member_ID = data;

            prepareMaterials();
        }

        private void prepareMaterials()
        {
            pictureBox2.Parent = pictureBox1;

            try
            {
                var q = from p in dbContext.Shop_Member_Info
                        where p.Member_ID == now_Member_ID
                        select new
                        {
                            等級ID = p.Level_ID,
                            等級名稱 = p.Game_Rank_Data.Rank_Name
                        };

                var result = q.FirstOrDefault();

                label1.Text = "等級: " + result.等級名稱;
                label1.Location = new System.Drawing.Point(0, 0);

                if ( result.等級ID >= 0 && result.等級ID <= 6 )
                {
                    string temp = "cat" + result.等級ID;
                    pictureBox2.Image = (Image)CatCaha.Properties.Resources.ResourceManager.GetObject(temp);
                    //pictureBox2.Image = CatCaha.Properties.Resources.cat6;


                } 
                else
                {
                    pictureBox2.Image = CatCaha.Properties.Resources.cat6;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int now_Member_ID;
        貓抓抓Entities1 dbContext = new 貓抓抓Entities1();
        //放在類別中供各地方可使用全域，先讓dbContext取得資料

        //傳遞資料
        public int DataProperty { get; set; }
        

    }
}
