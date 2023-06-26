using CatCaha.ProductsList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCaha.UserDataSouce
{
    public class UserDataList
    {
        CatChaEntities cat = new CatChaEntities();
        public List<UserData> GetUserDatas()
        {
            var user = cat.Shop_Member_Info.ToArray();
            return user.Select(u => new UserData
            { 
                Name = u.Name,


            }).ToList();
        }
    }
}
