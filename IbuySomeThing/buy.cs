using CatCaha.BuySomeThing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatCaha.IbuySomeThing
{
    public class buy : IsuccessBuyItems, IfailBuyItems,ICheckMoney
    {
        public void checkMoeny()
        {
            MessageBox.Show("no money");
        }
        public void successBuy()
        {
            MessageBox.Show("ok");
        }
        public void FailBuyItems()
        {
            MessageBox.Show("no");
        }
    }
}
