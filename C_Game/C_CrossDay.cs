using CatCaha.NewFolder1;
using CatChaForms;
using FormResize.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormResize
{

    public class C_CrossDay
    {
        private Frm_GameMain main = new Frm_GameMain();
        C_Query q = new C_Query();

        //這邊之後替換成資料庫或寫在settings?
        List<Button> dayChecked = new List<Button>(); //存放已經簽到的日子
        List<Button> dayUnChecked = new List<Button>();//存放還沒到的日子
        public bool IsMidnight()
        {
            DateTime now = DateTime.Now;
            return now.Hour == 0 && now.Minute == 0 && now.Second == 0;
        }

        public void DailyUpdateCheckin() //連動Form的timer，每次開啟時確認更新狀態
        {

            if (dayUnChecked.Count == 0) //如果全部天數都簽到了
            {
                
                foreach (Button b in dayChecked)
                {
                    dayUnChecked.Add(b);
                    tagInBuuton(b);
                }
                dayChecked.Clear();
                dayUnChecked[0].Enabled = true;
            }
            else
                dayUnChecked[0].Enabled = true;
        }

        public int CalculateMillisecondsToMidnight() //計算跨日時間與now時間的差
        {
            DateTime now = DateTime.Now;
            DateTime midnight = now.Date.AddDays(1); // 次日的午夜12點
            TimeSpan timeRemaining = midnight - now;
            return (int)timeRemaining.TotalMilliseconds;
        }




        public void checkIn(Button b)//一般簽到
        {

            b.Text = "已簽到";
            b.Enabled = false;
            dayChecked.Add(b);
            dayUnChecked.Remove(b);
            MessageBox.Show("簽到成功!");
            //Settings.Default.dailyCheckIn += 1;
            //Settings.Default.Save();
            q.updateCCoin();


            ProjectsModel dbContext = new ProjectsModel();
            var qcheckInDayCount = dbContext.Shop_Member_Info.FirstOrDefault(n => n.Member_ID == LoggedInUser.ID);
            if (qcheckInDayCount != null)
            {
                qcheckInDayCount.CheckinDayCount += 1;
                dbContext.SaveChanges();
            }
        }

        public void checkInCoupon(Button b)
        {

        }//酷碰券

        public void updateCheckInStatus(Form m)
        {
            //表單開啟時先把按鈕都加入未簽到的list

            foreach (Button b in m.Controls.OfType<Button>().Where(b => b.Tag != null && b.Tag.ToString().Contains("b")))
            {
                dayUnChecked.Add(b);
            }
            ProjectsModel dbContext = new ProjectsModel();
            var qcheckin = dbContext.Shop_Member_Info.FirstOrDefault(n => n.Member_ID == LoggedInUser.ID);
            for (int i = 1; i < qcheckin.CheckinDayCount - 1; i++)
            /*for (int i = 1; i <= Settings.Default.dailyCheckIn; i++)*///再自動還原上次的狀態
            {
                dayUnChecked[0].Text = "已簽到";
                dayUnChecked[0].Enabled = false;
                dayChecked.Add(dayUnChecked[0]);
                dayUnChecked.Remove(dayUnChecked[0]);
            }
            dayUnChecked[0].Enabled = true;
        }

        //設置按鈕的tag,存放要顯示的文字或是圖片
        public void tagInBuuton(Button b)
        {
            if (dayUnChecked.Contains(b))
            {
                switch (b.Tag.ToString())
                {
                    case ("b"):

                        b.Text = "100貓幣";
                        break;

                    case ("bgacha"):
                        b.Text = "紅利*500";
                        break;

                    case ("bCoupon"):
                        b.Text = "優惠券*1";
                        break;
                }
            }




        }

    }
}
