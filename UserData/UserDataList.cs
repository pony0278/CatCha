using CatCaha.List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCaha.UserData
{
    public class UserDataList : Newabstract<UserData>
    {
        public override List<UserData> GetUserDatas()
        {
            return new List<UserData> 
            {
            new UserData { ID=2, Name = "JohnT"},
            new UserData { ID=6, Name = "JoT"},
            new UserData { ID=4, Name = "JaeT" },
            };

        }
    }
}
