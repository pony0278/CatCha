using CatCaha.IcaptureData;
using CatCaha.IcaptureUserData;
using CatCaha.ProductsList;
using CatCaha.UserControlManger;
using CatCaha.UserDataSouce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatCaha.CallDataToFormm
{
    public class CallDataToForm
    {
        public void ShowProducts(Form form, FlowLayoutPanel flowLayoutPanel , Button button)
        {
            ProductsDataFromLinq data = new ProductsDataFromLinq();
            UserControlManager ControlManger = new UserControlManager();
            List<ProductsProperties> GetData;
            switch (button.Tag)
            {
                case "GetAll":
                    GetData = data.GetProducts();
                    break;
                case "1":
                    GetData = data.GetProductID1();
                    break;
                case "2":
                    GetData = data.GetProductID2();
                    break;
                case "3":
                    GetData = data.GetProductID3();
                    break;
                case "4":
                    GetData = data.GetProductID4();
                    break;
                default:
                    throw new Exception($"Unrecognized button tag: {button.Tag}");
            }
            Capture<ProductsProperties> capture = new Capture<ProductsProperties>();
            CaptureDataManager<ProductsProperties> captureDataManager = new CaptureDataManager<ProductsProperties>(capture);
            captureDataManager.Capture(GetData, form, flowLayoutPanel, button);
        }
        public void ShowUserData(GamePurchasePage form)
        {
            UserDataFromLinq data = new UserDataFromLinq();
            var userDataList = data.GetUserDatas();
            List<UserProperties> userPropertiesList = new List<UserProperties>();

            foreach (var userData in userDataList)
            {
                UserProperties userProperties = new UserProperties(userData);
                userPropertiesList.Add(userProperties);
            }

            captureUser<UserProperties> capture = new captureUser<UserProperties>();
            captureUserDataManager<UserProperties> captureUserDataManager = new captureUserDataManager<UserProperties>(capture);
            captureUserDataManager.captureUserData(userPropertiesList, form);
        }
        public void refreshUserData(GamePurchasePage form)
        {
            UserDataFromLinq data = new UserDataFromLinq();
            var refreshdata = data.UserDataRefresh();
            List<UserProperties> userProperties = new List<UserProperties>();
            foreach(var userData in refreshdata)
            {
                UserProperties userProperties1 = new UserProperties(userData);
                userProperties.Add(userProperties1);
            }
            captureUser<UserProperties> captureUser = new captureUser<UserProperties>();
            captureUserDataManager<UserProperties> captureUserDataManager = new captureUserDataManager<UserProperties>(captureUser);
            captureUserDataManager.captureUserData(userProperties, form);
        }

    }
}
