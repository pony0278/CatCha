using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCaha.ZongHanCompoents.UserOderData
{
    public class userGameOrder
    {
        public int MemberID {  get; set; }
        public int ProductID { get; set; }
        public string CharaterName { get; set; }
        public DateTime PurchaseTime { get; set; }
        public string ItemName { get; set; }
        public int ItemPurchaseRecordID { get; set; }
    }
}
