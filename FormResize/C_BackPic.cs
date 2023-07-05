using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormResize
{
    public class C_BackPic
    {
        Frm_GameMain main;
        //把資料庫的圖片抓近來
        //從資料庫抓使用者目前擁有的背景
        List<Image> bgPicFromDB = new List<Image>();
        public void _startLoad(Form f) //給小屋form呼叫載入初始背景圖片
        {
            foreach (PictureBox p in f.Controls.OfType<PictureBox>())
            {
                if (bgPicFromDB.Count != 0)
                {
                    for (int i = 0; i <= bgPicFromDB.Count(); i++)
                    {
                        p.Image = bgPicFromDB[i];
                    }
                }
            }
        }


    }
}
