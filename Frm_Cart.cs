using buttonHelper;
using Cart2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatCaha.NewFolder1;
using CatChaForms;

namespace CatCha
{
    public partial class Frm_Cart : Form
    {
        public Frm_Cart()
        {
            InitializeComponent();
            ColorHelper.ChangeButtonColor(btnCheckOut, "#E4BB97");
            ColorHelper.ChangeButtonColor(btnGoShop, "#E4BB97");

        }
        // 建立連線到資料庫的實體模型
        project123Entities dbContext = new project123Entities();
        public int CalculateTotalPrice()
        {
            int totalPrice = 0;

            foreach (Control control in flowLayoutPanelProducts.Controls)
            {
                if (control is ItemUserControl itemUserControl)
                {
                    int itemTotalPrice = Convert.ToInt32(itemUserControl.getTotalPrice());
                    totalPrice += itemTotalPrice;
                }
            }
            return totalPrice;
            ;

        }

        private void ItemUserControl_QuantityChanged(int newQuantity)
        {
            UpdateTotalAmount();
        }

        public void UpdateTotalAmount()
        {
            int total = CalculateTotalPrice();
            labTotalAmount.Text = $"總金額：{total:C2}";
            labBonus.Text = $"可獲得{total * 1000}紅利";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //點選超連結網址
            System.Diagnostics.Process.Start("https://www.catchatshop.com/");
        }
        int oID;            
        public int memberID = LoggedInUser.ID;

        private Image GetImageFromBytes(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
            {
                return null;
            }
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            };
        }

        private void btnCheckOut_Click_1(object sender, EventArgs e)
        {
            var productCount = this.flowLayoutPanelProducts.Controls.Find("labCount", true);
            int i = 0;
            foreach (ItemUserControl data in this.flowLayoutPanelProducts.Controls)
            {

                Shop_Order_Detail_Table q = (from od in dbContext.Shop_Order_Detail_Table
                                             where od.Order_ID == oID &&
                                             od.Product_ID == data.ItemProductID
                                             select od).ToList().First();

                q.Product_Quantity = (int)Convert.ToDecimal(productCount[i].Text);
                dbContext.SaveChanges();
                i++;

            }
            //到結帳區的頁面
            Frm_Cart2 frm_Cart2 = new Frm_Cart2();
            frm_Cart2.Show();
        }
        private void Frm_Cart_Load(object sender, EventArgs e)
        {

                //Step1:查詢memberID裡所有的OrderTotal裡orderStatusID是1的orderID
                var orderID = from ot in dbContext.Shop_Order_Total_Table
                          where ot.Member_ID == memberID && ot.Order_Status_ID == 1
                          select ot.Order_ID;
            //Step2:查詢訂單明細中和訂單ID相符的商品ID
            //如果有找到資料再進行下面的動作
            if (orderID.Any())
            {
                oID = orderID.First(); //取第一筆OrderID
                var productIDs = from od in dbContext.Shop_Order_Detail_Table
                                 where od.Order_ID == oID
                                 select od.Product_ID;
                //取得相符的訂單ID裡相符的productID裡的Product Quantity
                var productQuantity = (from od in dbContext.Shop_Order_Detail_Table
                                       where od.Order_ID == oID
                                       select od.Product_Quantity).ToList();
                //Step3:訂單ID裡所有的商品資料以及商品對應的圖片資料
                var products = from pt in dbContext.Shop_Product_Total
                               from pi in dbContext.Shop_Product_Image_Table
                               where pt.Product_ID == pi.Product_ID && productIDs.Contains(pt.Product_ID)
                               select new
                               {
                                   product = pt,
                                   picture = pi
                               };

                //先清空flowlayoutpanel
                this.flowLayoutPanelProducts.Controls.Clear();

                //遍歷搜尋的商品資料並逐一加到userItemControl裡
                int index = 0;
                foreach (var pro in products)
                {
                    ItemUserControl iuc = new ItemUserControl();
                    iuc.Size = new Size(flowLayoutPanelProducts.Width, iuc.Height);
                    //使用FirstOrDefault()方法獲取 data.Image 集合中的第一個Shop_Product_Image實體，
                    //然後再存取其 Product_photo 屬性。避免存取 data.Image 屬性時產生的編譯錯誤。
                    iuc.ItemImage = GetImageFromBytes(pro.picture.Product_Photo);
                    iuc.ItemName = pro.product.Product_Name;
                    iuc.ItemPrice = (decimal)pro.product.Product_Price;
                    iuc.ItemTotalPrice = (decimal)pro.product.Product_Price * (int)productQuantity[index];
                    //看到加進的Product_ID及OrderID
                    iuc.ItemProductID = pro.product.Product_ID;
                    iuc.OrderID=orderID.ToList().First();
                    MessageBox.Show(Convert.ToString(iuc.OrderID),Convert.ToString(iuc.ItemProductID));
                    iuc.ItemCount = (int)productQuantity[index];
                    index++;

                    this.flowLayoutPanelProducts.Controls.Add(iuc);

                    // 訂閱 ItemUserControl 的 QuantityChanged 事件
                    iuc.QuantityChanged += ItemUserControl_QuantityChanged;
                    UpdateTotalAmount();
                }
            }
        }
    }
}
