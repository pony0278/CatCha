using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.Windows.Forms;

namespace FormResize
{
    public class C_Query
    {
        貓抓抓Entities2 dbContext = new 貓抓抓Entities2();

        Frm_GameMain main;
        public string MemberAccount = "catCha2";
        string GameName = "";
        int MemberID = 0;
        List<byte> checkin = new List<byte>();
        List<byte> Unchecked = new List<byte>();
        string UserLV;
        int CatCoin;
        int RedStone;


        public int ID()
        {
            var qMemberID = from n in dbContext.Shop_Member_Info where n.Member_Account == MemberAccount select n.Member_ID;
            return int.Parse(qMemberID.FirstOrDefault().ToString());
        }
        public string _GameName() //找腳色名稱
        {
            var qGameName = from n in dbContext.Shop_Member_Info where n.Member_Account == MemberAccount select n.Character_Name;
            return qGameName.FirstOrDefault().ToString();
        }

        public string _GameCatCoin() //找貓幣數量
        {
            var qCatCoin = from n in dbContext.Shop_Member_Info where n.Member_Account == MemberAccount select n.Cat_Coin_Quantity;
            return qCatCoin.FirstOrDefault().ToString();
        }
        public string _GameRLPoint() //找紅利數量
        {
            var qLtPoint = from n in dbContext.Shop_Member_Info where n.Member_Account == MemberAccount select n.Loyalty_Points;
            return qLtPoint.FirstOrDefault().ToString();
        }

        public void updateCCoin()
        {
            var q = dbContext.Shop_Member_Info.FirstOrDefault(n => n.Member_Account == MemberAccount);
            if (q != null)
            {
                q.Cat_Coin_Quantity += 100;
                dbContext.SaveChanges();
              
            }
        }
    }
}
