using CatCaha.UserDataSouce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatCaha.IcaptureUserData
{
    public interface IcaptureData<T> where T : UserProperties
    {
        void captureData(List<T> items , GamePurchasePage form);
    }
}
