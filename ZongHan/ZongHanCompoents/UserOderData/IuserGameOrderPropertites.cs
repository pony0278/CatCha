using CatCaha.ProductsList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCaha.ZongHanCompoents.UserOderData
{
    public interface IuserGameOrderPropertites
    {
        int MemberID { get; set; }
        int ProductID { get; set; }
        string CharaterName { get; set; }
        DateTime PurchaseTime { get; set; }
        string ItemName { get; set; }
        int ItemPurchaseRecordID { get; set; }
    }

    public class userGameOrders : IuserGameOrderPropertites
    {
        public int MemberID { get; set; }
        public int ProductID { get; set; }
        public string CharaterName { get; set; }
        public DateTime PurchaseTime { get; set; }
        public string ItemName { get; set; }
        public int ItemPurchaseRecordID { get; set; }

        public userGameOrders(userGameOrder userGameOrder)
        {
            MemberID = userGameOrder.MemberID;
            ProductID = userGameOrder.ProductID;
            CharaterName = userGameOrder.CharaterName;
            PurchaseTime = userGameOrder.PurchaseTime;
            ItemName = userGameOrder.ItemName;
            ItemPurchaseRecordID = userGameOrder.ItemPurchaseRecordID;

        }
    }

}
