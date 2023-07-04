using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using CatCaha.NewFolder1;

namespace CatCaha
{
    public partial class OrderDetails : Form
    {
        public OrderDetails(int data_a, int data_b)
        {
            InitializeComponent();

            now_Member_ID = data_a;
            now_Order_ID = data_b;

            prepareMaterials();

        }

        //載入預設資料
        private void prepareMaterials()
        {
            try
            {

                //處理收件人名稱和地址:假資料
                var u = from p in dbContext.Shop_Order_Total_Table
                        join x in dbContext.Shop_Common_Address_Data on p.Address_ID equals x.Address_ID
                        where p.Order_ID == now_Order_ID
                        select new
                        {
                            收件人 = x.Recipient_Name,
                            收件人地址 = x.Recipient_Address,
                        };

                var item2 = u.FirstOrDefault();

                textBox2.Text = item2.收件人.ToString();
                textBox3.Text = item2.收件人地址.ToString();

                //處理收件人電話
                var q = dbContext.Shop_Order_Total_Table
                        .Where(p => p.Order_ID == now_Order_ID)
                        .Select(p => p.Recipient_Phone)
                        .DefaultIfEmpty();

                //處理優惠券代碼
                var s = dbContext.Shop_Order_Total_Table
                        .Where(p => p.Order_ID == now_Order_ID)
                        .Select(p => p.Coupon_ID)
                        .DefaultIfEmpty();

                textBox4.Text = "0" + q.Average();
                textBox6.Text = "" + s.Average();



                var r = from p in dbContext.Shop_Order_Detail_Table
                            where p.Order_ID == now_Order_ID
                            select new
                            {
                                商品名稱 = p.Shop_Product_Total.Product_Name,
                                購買單價 = p.Shop_Product_Total.Product_Price,
                                購買數量 = p.Product_Quantity,
                                優惠總額 = p.Shop_Product_Total.Product_Price * p.Product_Quantity
                            };


                //計算優惠總額 和 將表格加入資料
                decimal totalPrice = 0;
                foreach (var item in r)
                {
                    dataGridView1.Rows.Add(new object[] { item.商品名稱, Convert.ToInt32( item.購買單價 ), item.購買數量 });
                    totalPrice = totalPrice + item.優惠總額.Value;
                }
                
                textBox5.Text = "NT$ " + Convert.ToInt32(totalPrice);
                //這裡還要乘上優惠券的折扣後，轉decimal的型別為int
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int now_Member_ID, now_Order_ID;
        貓抓抓Entities1 dbContext = new 貓抓抓Entities1();
        //放在類別中供各地方可使用全域，先讓dbContext取得資料

        //傳遞資料
        public int DataProperty { get; set; }
    }
}
