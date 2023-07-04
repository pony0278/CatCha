using CatCaha.IbuySomeThing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCaha.BuySomeThing
{
    public class BuyManager
    {
        public void checkCurrentMoney(ICheckMoney item)
        {
            item.checkMoeny();
        }
        public void SuccessBuy(IsuccessBuyItems item)
        {
            item.successBuy();
        }
        public void Fail(IfailBuyItems item)
        {
            item.FailBuyItems();
        }
    }
}
