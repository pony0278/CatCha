using CatCaha.UserDataSouce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatCaha.IcaptureUserData
{
    public class captureUserDataManager<T> where T : UserProperties
    {
        private IcaptureData<T> _IcaptureData;
        public captureUserDataManager (IcaptureData<T> captureData)
        {
            _IcaptureData = captureData;
        }
        public void captureUserData(List<T> user , GamePurchasePage form)
        {
            _IcaptureData.captureData(user ,form);
        }
    }
}
