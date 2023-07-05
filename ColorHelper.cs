using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttonHelper
{
    
    public static class ColorHelper
    {
        //專門更改按鈕顏色的方法
        public static void ChangeButtonColor(Button button, string colorCode) 
        { 
        button.BackColor=ColorTranslator.FromHtml(colorCode);
        }

        //專門更改Form背景色
        public static void ChangeFormColor(Form form, string colorCode)
        { 
        form.BackColor=ColorTranslator.FromHtml(colorCode);
        }
    }
    
}
