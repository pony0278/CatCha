using CatCaha.ProductsList;
using CatCaha.UserDataSouce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCaha.BuySomeThing
{
    public interface IBuyItems<TUser, TProduct>
    where TUser : IUserProperties
    where TProduct : IProductsProperties
    {
        string BuyWithCatcoin(TUser user, TProduct product);
    }
}
