using System;
using CatCaha.NewFolder1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.Windows.Forms;
using CatChaForms;

namespace FormResize
{
    public class C_Query
    {
        project123Entities dbContext = new project123Entities();

        Frm_GameMain main;
        
        public string MemberAccount = "catCha2";
        //string GameName = LoggedInUser.Username;
        int MemberID = LoggedInUser.ID;
        List<byte> checkin = new List<byte>();
        List<byte> Unchecked = new List<byte>();
        string UserLV;
        int CatCoin;
        int RedStone;
  


        public int ID()
        {
            var qMemberID = from n in dbContext.Shop_Member_Info where n.Member_ID == LoggedInUser.ID select n.Member_ID;

            //var qMemberID = from n in dbContext.Shop_Member_Info where n.Member_Account == MemberAccount select n.Member_ID;
            return int.Parse(qMemberID.FirstOrDefault().ToString());
        }
        public string _GameName() //找腳色名稱
        {
                var qGameName = from n in dbContext.Shop_Member_Info where n.Member_ID == LoggedInUser.ID select n.Character_Name;

                //var qGameName = from n in dbContext.Shop_Member_Info where n.Member_Account == MemberAccount select n.Character_Name;
                return qGameName.FirstOrDefault().ToString();
        }

        public string _GameCatCoin() //找貓幣數量
        {
            var qCatCoin = from n in dbContext.Shop_Member_Info where n.Member_ID == LoggedInUser.ID select n.Cat_Coin_Quantity;

            //var qCatCoin = from n in dbContext.Shop_Member_Info where n.Member_Account == MemberAccount select n.Cat_Coin_Quantity;
            return qCatCoin.FirstOrDefault().ToString();
        }
        public string _GameRLPoint() //找紅利數量
        {
            var qLtPoint = from n in dbContext.Shop_Member_Info where n.Member_ID == LoggedInUser.ID select n.Loyalty_Points;

            //var qLtPoint = from n in dbContext.Shop_Member_Info where n.Member_Account == MemberAccount select n.Loyalty_Points;
            return qLtPoint.FirstOrDefault().ToString();
        }

        public void updateCCoin()
        {
            var q = dbContext.Shop_Member_Info.FirstOrDefault(n => n.Member_ID == MemberID);

            //var q = dbContext.Shop_Member_Info.FirstOrDefault(n => n.Member_Account == MemberAccount);
            if (q != null)
            {
                q.Cat_Coin_Quantity += 100;
                dbContext.SaveChanges();
              
            }
        }

        public void updateRuby()
        {
            var q = dbContext.Shop_Member_Info.FirstOrDefault(n => n.Member_ID == MemberID);

            //var q = dbContext.Shop_Member_Info.FirstOrDefault(n => n.Member_Account == MemberAccount);
            if (q != null)
            {
                q.Loyalty_Points += 500;
                dbContext.SaveChanges();

            }
        }
    }
}
