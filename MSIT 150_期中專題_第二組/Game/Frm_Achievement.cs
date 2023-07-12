using System;
using CatCaha.NewFolder1;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatChaForms;

namespace FormResize
{
    public partial class Frm_Achievement : Form
    {
        private Frm_GameMain mainForm;
        C_CrossDay crossDay;
        C_Query q = new C_Query();

        public Frm_Achievement(Frm_GameMain ParentForm)
        {

            mainForm = ParentForm;
            crossDay = new C_CrossDay();
            InitializeComponent();
            GlobelSetting._HIDEFORMCONTROL(this);


            //正式上線用
            //timer_CrossDay.Interval = crossDay.CalculateMillisecondsToMidnight();
            //測試用
            timer_CrossDay.Interval = 1000;
            timer_CrossDay.Tick += timer_CrossDay_Tick;
            timer_CrossDay.Start();
            crossDay.updateCheckInStatus(this);

        }
        private void timer_CrossDay_Tick(object sender, EventArgs e)
        {
            //測試用
            crossDay.DailyUpdateCheckin();


            //正式用
            if (crossDay.IsMidnight())
            {
                MessageBox.Show("日期已更新，將返回大廳");
                //跨夜後執行
                //crossDay.DailyUpdateCheckin();
                // 重新計算並設定計時器的間隔，以達到每日更新
                timer_CrossDay.Interval = crossDay.CalculateMillisecondsToMidnight();
                this.Close();
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            timer_CrossDay.Stop();
            this.Close();
        }

        private void btn_D1_Click(object sender, EventArgs e)
        {
            crossDay.checkIn(this.btn_D1);
            refreshMain();
        }

        private void btn_D2_Click(object sender, EventArgs e)
        {
            crossDay.checkIn(this.btn_D2);
            refreshMain();
        }

        private void btn_D3_Click(object sender, EventArgs e)
        {
            crossDay.checkIn(this.btn_D3);
            refreshMain();
        }

        private void btn_D4_Click(object sender, EventArgs e)
        {
            crossDay.checkIn(this.btn_D4);
            refreshMain();
        }

        private void btn_D5_Click(object sender, EventArgs e)
        {
            crossDay.checkIn(this.btn_D5);
            refreshMain();
        }

        private void btn_D6_Click(object sender, EventArgs e)
        {
            crossDay.checkIn(this.btn_D6);
            refreshMain();
        }

        private void btn_D7_Click(object sender, EventArgs e)
        {

            crossDay.checkInDaySeven(this.btn_D7);
            refreshMain();
        }

        private void btn_D8_Click(object sender, EventArgs e)
        {
            crossDay.checkIn(this.btn_D8);
            refreshMain();
        }

        private void btn_D9_Click(object sender, EventArgs e)
        {
            crossDay.checkIn(this.btn_D9);
            refreshMain();
        }

        private void btn_D10_Click(object sender, EventArgs e)
        {
            crossDay.checkIn(this.btn_D10);
            refreshMain();
        }

        private void btn_D11_Click(object sender, EventArgs e)
        {
            crossDay.checkIn(this.btn_D11);
            refreshMain();
        }

        private void btn_D12_Click(object sender, EventArgs e)
        {
            crossDay.checkIn(this.btn_D12);
            refreshMain();
        }

        private void btn_D13_Click(object sender, EventArgs e)
        {
            crossDay.checkIn(this.btn_D13);
            refreshMain();
        }

        private void btn_D14_Click(object sender, EventArgs e)
        {
            crossDay.checkIn(this.btn_D14);
            //Properties.Settings.Default.dailyCheckIn = 0;
            //Properties.Settings.Default.Save();
            project123Entities dbContext = new project123Entities();
            var qcheckInDayCount = dbContext.Shop_Member_Info.FirstOrDefault(n => n.Member_ID == LoggedInUser.ID);
            if (qcheckInDayCount != null)
            {
                qcheckInDayCount.CheckinDayCount = 0;
                dbContext.SaveChanges();
            }
            refreshMain();
        }

        private void Frm_Achievement_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void refreshMain() 
        {
            project123Entities db = new project123Entities();
            var qCatCoin = db.Shop_Member_Info.Where(n =>  n.Member_ID == LoggedInUser.ID).Select(n => n.Cat_Coin_Quantity);
            var qRuby = db.Shop_Member_Info.Where(n => n.Member_ID == LoggedInUser.ID).Select(n => n.Loyalty_Points);
            mainForm.txt_CatCoin.Text = qCatCoin.FirstOrDefault().ToString();
            mainForm.txt_RedStone.Text = qRuby.FirstOrDefault().ToString();
        }
    }
}
