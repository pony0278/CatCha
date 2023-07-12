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


}
