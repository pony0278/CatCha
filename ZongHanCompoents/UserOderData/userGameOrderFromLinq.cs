using CatCaha.ProductsList;
using CatCaha.UserDataSouce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCaha.ZongHanCompoents.UserOderData
{
    public class userGameOrderFromLinq
    {
        CatChaEntities cat = new CatChaEntities();

        public List<userGameOrder> GetAllOder() 
        {
            var user = cat.Game_Item_Purchase_Record.ToArray();
            return user.Select(u =>
            {
                DateTime dateTime;
                if (DateTime.TryParse(u.Purchase_Time, out dateTime))
                {
                    return new userGameOrder
                    {
                        MemberID = (int)u.Member_ID,
                        ProductID = (int)u.Product_ID,
                        CharaterName = u.Character_Name,
                        PurchaseTime = dateTime,
                        ItemName = u.Item_Name,
                        ItemPurchaseRecordID = u.Game_Item_Purchase_Record_ID
                    };
                }
                else
                {
                    return new userGameOrder();
                }
            }).ToList();
        }
        public List<userGameOrder> oderbyTime()
        {
            return GetAllOder().OrderByDescending(t  => t.PurchaseTime).ToList();
        }

    }
}

