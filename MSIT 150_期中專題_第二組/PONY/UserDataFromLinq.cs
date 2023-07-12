using CatCaha.ProductsList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatCaha.NewFolder1;
using CatChaForms;

namespace CatCaha.UserDataSouce
{
    public class UserDataFromLinq
    {
        project123Entities cat = new project123Entities();
        public List<UserData> GetUserDatas()
        {
            var ID = LoggedInUser.ID;
            return cat.Shop_Member_Info
                .Where(u => u.Member_ID == ID)
                .Select(u => new UserData
                {
                    Name = u.Name,
                    catcoin = (int)u.Cat_Coin_Quantity,
                    LoyaltyPoints = (int)u.Loyalty_Points
                }).ToList();
        }
        public List<UserData> UserDataRefresh()
        {
            using(var u  = new project123Entities())
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
