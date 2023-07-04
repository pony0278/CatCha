using CatCaha.UserDataSouce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatCaha.ZongHanCompoents.IbuySomeThing
{
    public interface IChargeCoin<Tuser> 
        where Tuser : IUserProperties
    {
        string chargeCoin(Tuser tuser, ChargeAmount charge);
    }
}
