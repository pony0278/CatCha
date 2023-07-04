using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCaha.UserData
{
    public abstract class Newabstract<T> where T : UserProperties
    {
        public abstract List<T> GetUserDatas();
    }
}
