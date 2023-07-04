using CatCaha.UserData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatCaha.IcaptureUserData
{
    public class captureUser<T> : IcaptureData<T> where T : UserProperties
    {
        public void captureData(List<T> items, Form3 form)
        {
            UserDataList user = new UserDataList();
            var GetUser = user.GetUserDatas();
            Form3 form3 = form;
            form3.SetLabel1(GetUser[0].ID);
            form3.SetLabel2(GetUser[0].ID);
        }
    }
}
