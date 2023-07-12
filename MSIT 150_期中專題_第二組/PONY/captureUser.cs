using CatCaha.UserDataSouce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatCaha.IcaptureUserData
{
    public class captureUser<T> : IcaptureData<T> where T : UserProperties
    {
        public void captureData(List<T> items, GamePurchasePage form)
        {
            var users = items;  
            GamePurchasePage form3 = form;
            //form3.SetCatCoin(users[0].CatCoin);
            //form3.SetLoyalitPotint(users[0].LoyaltyPoints);
        }
    }
}
