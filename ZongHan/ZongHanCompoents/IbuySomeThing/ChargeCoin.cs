using CatCaha.UserDataSouce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCaha.ZongHanCompoents.IbuySomeThing
{
    public class ChargeCoin : IChargeCoin<IUserProperties>
    {
        public string chargeCoin(IUserProperties userProperties, ChargeAmount charge)
        {
            return chargeToWallet(userProperties, charge.Amount, (amount, user) =>
            {
                user.CatCoin += amount;
            });
        }

        private string chargeToWallet(IUserProperties user, int Amount, Action<int, IUserProperties> updateMoney)
        {
            updateMoney(Amount, user);
            return "ok";
        }
    }

    public class ChargeAmount
    {
        public int Amount { get; set; }
    }
}

