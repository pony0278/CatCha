using CatCaha.IcaptureData;
using CatCaha.List;
using CatCaha.UserControlManger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatCaha.CallDataToForm
{
    public class CallTeacherData
    {
        public void Test(Form form, FlowLayoutPanel flowLayoutPanel , Button button)
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
    }
}
