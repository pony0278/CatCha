using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatCaha.UserControlManger
{
    public class UserControlManager
    {
        public void ClearUserControlData(FlowLayoutPanel flowLayoutPanel)
        {
            foreach (Control control in flowLayoutPanel.Controls)
            {
                if (control is gPurchasePageUC uc1)
                {
                    uc1.ClearData();
                }
            }
        }
    }
}
