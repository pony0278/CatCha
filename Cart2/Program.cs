using CatCha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttonHelper
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Cart());
            //Application.Run(new Frm_Cart2());
            //Application.Run(new Frm_Cart3());

            //Application.Run(new test());
        }
    }
}
