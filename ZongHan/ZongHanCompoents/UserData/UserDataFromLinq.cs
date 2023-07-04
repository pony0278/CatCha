using CatCaha.ProductsList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatCaha.ZongHan;

namespace CatCaha.UserDataSouce
{
    public class UserDataFromLinq
    {
        CatChaEntities cat = new CatChaEntities();
        public List<UserData> GetUserDatas()
        {
            return cat.Shop_Member_Info
                .Where(u => u.Member_ID == 1)
                .Select(u => new UserData
                {
                    Name = u.Name,
                    catcoin = (int)u.Cat_Coin_Quantity,
                    LoyaltyPoints = (int)u.Loyalty_Points
                }).ToList();
        }
        public List<UserData> UserDataRefresh()
        {
            using(var u  = new CatChaEntities())
            {
                return u.Shop_Member_Info
                    .Where(user => user.Member_ID == 1)
                    .Select(user => new UserData
                    {
                        Name = user.Name,
                        catcoin = (int)user.Cat_Coin_Quantity,
                        LoyaltyPoints = (int)user.Loyalty_Points
                    }).ToList();
            }
        }
    }
}
