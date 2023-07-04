using CatCaha.IcaptureData;
using CatCaha.IcaptureUserData;
using CatCaha.List;
using CatCaha.UserControlManger;
using CatCaha.UserData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatCaha.CallDataToForm
{
    public class CallDataToForm
    {
        public void ShowProducts(Form form, FlowLayoutPanel flowLayoutPanel , Button button)
        {
            TeacherListData data = new TeacherListData();
            UserControlManager ControlManger = new UserControlManager();
            List<Teacher> GetData;
            switch (button.Tag)
            {
                case "GetAll":
                    ControlManger.ClearUserControlData(flowLayoutPanel);
                    GetData = data.GetPeople();
                    break;
                case "OverThan20":
                    ControlManger.ClearUserControlData(flowLayoutPanel);
                    GetData = data.GetTeachersOlderThan20();
                    break;
                default:
                    throw new Exception($"Unrecognized button tag: {button.Tag}");
            }
            Capture<List.Teacher> capture = new Capture<List.Teacher>();
            CaptureDataManager<List.Teacher> captureDataManager = new CaptureDataManager<List.Teacher>(capture);
            captureDataManager.Capture(GetData, form, flowLayoutPanel, button);
        }
        public void ShowUserData(Form3 form)
        {
            UserDataList data = new UserDataList();
            var a = data.GetUserDatas();
            captureUser<UserData.UserData> capture = new captureUser<UserData.UserData>();
            captureUserDataManager<UserData.UserData> captureUserDataManager = new captureUserDataManager<UserData.UserData>(capture);
            captureUserDataManager.captureUserData(a, form);
        }
    }
}
