using CatCaha.List;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatCaha;
using System.Drawing;
using CatCaha.UserControlManger;
using static CatCaha.List.TeacherListData;
using System.Net.Sockets;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CatCaha.IcaptureData
{
    public class Capture<T> : ICaptureImages<T> where T : Person
    {
        public void captureImages(List<T> people, Form form, FlowLayoutPanel flowLayoutPanel, Button button)
        {
            TeacherListData data = new TeacherListData();
            List<Teacher> GetData;

            switch (button.Tag)
            {
                case "GetAll":
                    GetData = data.GetPeople();
                    break;
                case "OverThan20":
                    GetData = data.GetTeachersOlderThan20();
                    break;
                default:
                    throw new Exception($"Unrecognized button tag: {button.Tag}");
            }

            // Get current number of user controls
            int currentControlCount = flowLayoutPanel.Controls.OfType<UserControl1>().Count();

            // Remove excess user controls
            while (currentControlCount > GetData.Count)
            {
                flowLayoutPanel.Controls.RemoveAt(currentControlCount - 1);
                currentControlCount--;
            }

            // Add additional user controls
            while (currentControlCount < GetData.Count)
            {
                UserControl1 uc = new UserControl1();
                uc.Dock = DockStyle.Top;
                flowLayoutPanel.Controls.Add(uc);
                currentControlCount++;
            }

            // Set data for user controls
            for (int i = 0; i < GetData.Count; i++)
            {
                UserControl1 uc1 = (UserControl1)flowLayoutPanel.Controls[i];
                uc1.SetImage(GetData[i].Image);
                uc1.SetLabel1Text(GetData[i].ID);
                uc1.SetLabe2Text(GetData[i].Name);
            }
        }

    }

}
