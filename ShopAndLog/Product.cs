using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatCaha.NewFolder1;

namespace CatChaForms
{
    public partial class Product : Form
    {
        project123Entities dbContext = new project123Entities();

        private int productId;
        public Product(int getProductId) //把Product ID傳過來
        {
            InitializeComponent();

            this.productId = getProductId;

            //禁止放大：
            //1. 屬性視窗在屬性窗口中MaximizeBox 屬性設置為 False。
            //2. 將FormBorderStyle 屬性設置為 FixedSingle 或 FixedDialog。

            var SelectProd = dbContext.Shop_Product_Total.FirstOrDefault(p => p.Product_ID == getProductId);
                var SelectImg = dbContext.Shop_Product_Image_Table.FirstOrDefault(i => i.Product_ID == getProductId);

                if (SelectProd != null)
                {

                    //=============form標題
                    this.Text = SelectProd.Product_Name;

                    //=============商品圖片

                    var img = SelectImg.Product_Photo;
                    System.Drawing.Image img_result = (Bitmap)((new ImageConverter()).ConvertFrom(img));
                    pictureBox1.Image = img_result;

                    //=============商品名稱
                    label1.Text = SelectProd.Product_Name;
                    
                    //=============抓到價格顯示要去掉小數點
                    decimal? money = SelectProd.Product_Price;
                    decimal price = money.GetValueOrDefault();  // 獲取實際的decimal值

                // 去掉小數點後的位數，並添加"NT$"前綴
                string formattedPrice = "NT$" + Math.Floor(price).ToString();
                label2.Text = formattedPrice;

                //=============數量
                for (int i = 1; i <= SelectProd.Remaining_Quantity; i++)
                    {
                        RemainingQuantity.Items.Add(i);
                    }
                    RemainingQuantity.SelectedIndex = 0;

                    //==============商品描述
                    label4.Text = SelectProd.Product_Description == null ? "這裡還沒有描述說明~" : SelectProd.Product_Description;
            }
        }

        //獲取Order ID
        int GetOrderID = 0;
        private void AddToCart_Click(object sender, EventArgs e)
        {
            if (LoggedInUser.Username == null && LoggedInUser.ID == 0)
            {
                MessageBox.Show("請先登入");
                Signin form = new Signin();
                form.ShowDialog();
            }
            else
            {
                //===================表示有登入，可以新增
                //==============//先判斷OrderTotal是否存在這個會員跟訂單狀態，如果兩個條件都沒有符合則新增到OrderTotal

                // 查询条件
                var existingOrder = dbContext.Shop_Order_Total_Table.FirstOrDefault(o => o.Member_ID == LoggedInUser.ID && o.Order_Status_ID == 1);

                //====================沒有符合條件的
                if (existingOrder == null)
                {
                    // 建立新的資料物件
                    Shop_Order_Total_Table newOrder = new Shop_Order_Total_Table
                    {
                        Member_ID = LoggedInUser.ID,
                        Order_Creation_Date = DateTime.Now,
                        Last_Update_Time = DateTime.Now,
                        Order_Status_ID = 1,
                    };

                    //=============寫入資料庫
                    dbContext.Shop_Order_Total_Table.Add(newOrder);
                    dbContext.SaveChanges();

                    //=============再insert到detail
                    InsertToOrderDetail();
                    MessageBox.Show("新增至購物車成功!");
                }
                else
                {
                    //有符合條件的就只需要insert到detail
                    //條件：product id 跟 order id是不是有存在，有存在必須累加
                    //沒有則新增一條在明細裡

                    var getOrderID = dbContext.Shop_Order_Total_Table.FirstOrDefault(o => o.Member_ID == LoggedInUser.ID && o.Order_Status_ID == 1);
                    GetOrderID = getOrderID.Order_ID;

                    // 查询条件
                    var existingDetail = dbContext.Shop_Order_Detail_Table.FirstOrDefault(o => o.Product_ID == productId && o.Order_ID == GetOrderID);

                    //====================沒有符合條件的直接新增
                    if (existingDetail == null)
                    {
                        InsertToOrderDetail();
                        MessageBox.Show("新增至購物車成功!");
                    }
                    //====================這裡針對Product Quantity加上combox的數字
                    else
                    {
                        //把comboxBox的值丟過去
                        string haha = this.RemainingQuantity.SelectedItem.ToString();
                        // 更新產品数量
                        existingDetail.Product_Quantity += int.Parse(haha);

                        // 保存更改到数据库
                        dbContext.SaveChanges();
                        MessageBox.Show("新增至購物車成功!");
                    }
                }
            }
        }


        private void InsertToOrderDetail()
        {
            var getOrderID = dbContext.Shop_Order_Total_Table.FirstOrDefault(o => o.Member_ID == LoggedInUser.ID && o.Order_Status_ID == 1);

            GetOrderID = getOrderID.Order_ID;

            Shop_Order_Detail_Table orderDetail = new Shop_Order_Detail_Table
            {
                Order_ID = GetOrderID, //抓資料表的ID
                Product_ID = productId, //抓點擊的商品ID
                Product_Quantity = 1,
            };

            //=============寫入資料庫
            dbContext.Shop_Order_Detail_Table.Add(orderDetail);
            dbContext.SaveChanges();
        }
    }
}
