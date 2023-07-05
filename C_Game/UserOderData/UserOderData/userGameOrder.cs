using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCaha.ZongHanCompoents.UserOderData
{
    public class userGameOrder
    {
        public int MemberID { get; internal set; }

        public int ProductID { get; internal set; }
        public string CharaterName { get; internal set; }
        public DateTime PurchaseTime { get; internal set; }
        public string ItemName { get; internal set; }
        public int ItemPurchaseRecordID { get; internal set; }
        public byte[] ProductPic { get; internal set; }
    }
}
