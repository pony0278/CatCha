using FormResize.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormResize
{
    public class C_Backpack
    {

        Frm_GameMain main ;
        //把資料庫的圖片抓近來
        List<Image> petFromDB = new List<Image>();
        List<Image> itemFromDB = new List<Image>();
        List<Image> allFromDB = new List<Image>();

        //TODO 把放置貓的功能改到這裡



        public void _startLoad(Form f) //給背包form呼叫載入初始背包物品圖片
        {
            foreach (PictureBox p in f.Controls.OfType<PictureBox>())
            {
                _setItemToPicBox(p);
            }
        }

        public void _setItemToPicBox(PictureBox p) //根據不同種類的背包置換對應的圖片
        {
            switch (p.Tag)
            {
                case ("pet"):

                    if (petFromDB.Count != 0)
                    {
                        for (int i = 0; i <= petFromDB.Count(); i++)
                        {
                            p.Image = petFromDB[i];
                        }
                    }
                    break;


                case ("item"):

                    if (itemFromDB.Count != 0)
                    {
                        for (int i = 0; i <= itemFromDB.Count(); i++)
                        {
                            p.Image = itemFromDB[i];
                        }
                    }
                    break;

                default:

                    if (allFromDB.Count != 0 || petFromDB.Count != 0)
                    {
                        for (int i = 0; i <= allFromDB.Count(); i++)
                        {
                            p.Image = itemFromDB[i];
                        }
                    }
                    break;
            }

        }

        //public void _picIsCat(PictureBox p) //TODO 前面把圖片從DB放到資料庫之後，要寫判斷加上tag，這邊才能用
        //{
        //    switch (p.Tag.ToString())
        //    {
        //        case ("cat_y"):
        //            create_Cat_y(main, main.pic_Back);
        //            break;
        //        case ("cat_g"):
        //            create_Cat_g(main,main.pic_Back);
        //            break;
        //        case ("cat_w"):
        //            create_Cat_w(main, main.pic_Back);
        //            break;
        //    }
        //}
    }
}
