using CatCaha.NewFolder1;
using CatCaha.UserDataSouce;
using CatChaForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CatCaha.ZongHanCompoents.IbuySomeThing
{
    public class ChargeCoin : IChargeCoin<IUserProperties>
    {
        project123Entities cat = new project123Entities();
        public string chargeCoin(IUserProperties userProperties, ChargeAmount charge)
        {
            var ID = LoggedInUser.ID;
            return chargeToWallet(userProperties, charge.Amount, (amount, user) =>
            {
                user.CatCoin += amount;

                var users = cat.Shop_Member_Info.FirstOrDefault(u => u.Member_ID == ID);
                if (users != null)
                {
                    users.Cat_Coin_Quantity = user.CatCoin;
                    cat.SaveChanges();
                }

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

