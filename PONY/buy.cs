using CatCaha.BuySomeThing;
using CatCaha.ProductsList;
using CatCaha.UserDataSouce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatCaha.IbuySomeThing
{
    public class BuyItems : IBuyItems<IUserProperties, IProductsProperties>
    {
        public string BuyWithCatcoin(IUserProperties user, IProductsProperties product)
        {
            return Buy(user, product, user.CatCoin, user.UpdateCatCoin);
        }

        public string BuyWithLoyaltyPoints(IUserProperties user, IProductsProperties product)
        {
             return Buy(user, product, user.LoyaltyPoints, user.UpdateLoyaltyPoints);
        }

        private string Buy(IUserProperties user, IProductsProperties product, int currentMoney, Action<int, IProductsProperties> updateMoney)
        {
            // Calculate the new amount of money the user should have after buying the product
            int newMoney = currentMoney - product.ProductsPrice;

            if (newMoney < 0)
            {
                return "額度不足";
            }

            // Change the user's money
            updateMoney(newMoney, product);

            return "成功";
        }
    }

}
