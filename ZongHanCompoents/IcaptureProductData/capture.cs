using CatCaha.ProductsList;
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
using static CatCaha.ProductsList.ProductsDataFromLinq;
using System.Net.Sockets;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CatCaha.IcaptureData
{
    public class Capture<T> : ICaptureImages<T> where T : ProductsProperties
    {
        public void captureImages(List<T> people, Form form, FlowLayoutPanel flowLayoutPanel, Button button)
        {
            ProductsDataFromLinq data = new ProductsDataFromLinq();
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

            // Get current number of user controls
            int currentControlCount = flowLayoutPanel.Controls.OfType<gPurchasePageUserControl1>().Count();

            // Remove excess user controls
            while (currentControlCount > GetData.Count)
            {
                flowLayoutPanel.Controls.RemoveAt(currentControlCount - 1);
                currentControlCount--;
            }

            // Add additional user controls
            while (currentControlCount < GetData.Count)
            {
                gPurchasePageUserControl1 uc = new gPurchasePageUserControl1();
                //uc.Dock = DockStyle.Top;
                flowLayoutPanel.Controls.Add(uc);
                currentControlCount++;
            }

            // Set data for user controls
            for (int i = 0; i < GetData.Count; i++)
            {
                gPurchasePageUserControl1 uc1 = (gPurchasePageUserControl1)flowLayoutPanel.Controls[i];
                uc1.SetImage(GetData[i].Image);
                uc1.SetProductName(GetData[i].ProductsName);
                uc1.SetProductPrice(GetData[i].ProductsPrice);
                uc1.SetProductDesprict(GetData[i].ProductDescription);
                uc1.SetProductID(GetData[i].ProductID);
            }
        }

    }

}
