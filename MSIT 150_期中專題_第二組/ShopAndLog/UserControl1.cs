﻿using CatChaForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using CatCaha.NewFolder1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace catcha
{
    public partial class ProductControl : UserControl
    {
        project123Entities dbContext = new project123Entities();

        private int productID;
        private Color defaultBackColor; // 原始的背景色
        public ProductControl()
        {
            InitializeComponent();
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            defaultBackColor = button3.BackColor; // 保存原始的背景色

            AddToCart.BackColor = System.Drawing.Color.FromArgb(228, 187, 151);
            AddToCart.FlatStyle = FlatStyle.Flat;
            AddToCart.FlatAppearance.BorderColor = Color.White;
            AddToCart.FlatAppearance.BorderSize = 1;
        }

        public string NameLabelText
        {
            get { return nameLabel.Text; }
            set { nameLabel.Text = value; }
        }

        public string PriceLabelText
        {
            get { return priceLabel.Text; }
            set { priceLabel.Text = value; }
        }

        public System.Drawing.Image ProductImage
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public int getProductId
        {
            get { return productID; }
            set { productID = value; }
        }

        public string getDate
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show(productID.ToString());
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            //===================傳商品ID過去
            Product form = new Product(getProductId);
            form.ShowDialog(); //禁止使用者按到背景的東西(加入購物車....導致不停加入問題)
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
            else {
                //===================表示有登入，可以新增
                //==============//先判斷OrderTotal是否存在這個會員跟訂單狀態，如果兩個條件都沒有符合則新增到OrderTotal

                // 查询条件
                var existingOrder = dbContext.Shop_Order_Total_Table.FirstOrDefault(o => o.Member_ID == LoggedInUser.ID && o.Order_Status_ID == 1);

                //MessageBox.Show("Member ID = " + LoggedInUser.ID);

                //====================沒有符合條件的
                if (existingOrder == null)
                    {
                        // 建立新的資料物件
                        Shop_Order_Total_Table newOrder = new Shop_Order_Total_Table
                        {
                            Member_ID = LoggedInUser.ID,
                            Order_Creation_Date = DateTime.Now,
                            Last_Update_Time = DateTime.Now,
                            //Address_ID = memberId,
                            //Recipient_Address = "",
                            //Recipient_Name = "",
                            //Recipient_Phone = "",
                            Order_Status_ID = 1,
                            //Payment_Method_ID = "",
                            //Coupon_ID = "",
                        };

                        //=============寫入資料庫
                        dbContext.Shop_Order_Total_Table.Add(newOrder);
                        dbContext.SaveChanges();

                    //=============再insert到detail
                    InsertToOrderDetail();
                    MessageBox.Show("新增至購物車成功!");
                }
                    else {
                    //有符合條件的就只需要insert到detail
                    //條件：product id 跟 order id是不是有存在，有存在必須累加
                    //沒有則新增一條在明細裡
                    
                    var getOrderID = dbContext.Shop_Order_Total_Table.FirstOrDefault(o => o.Member_ID == LoggedInUser.ID && o.Order_Status_ID == 1);
                    GetOrderID = getOrderID.Order_ID;
                    //MessageBox.Show("GetOrderID = " + GetOrderID);

                    // 查询条件
                    var existingDetail = dbContext.Shop_Order_Detail_Table.FirstOrDefault(o => o.Product_ID == getProductId && o.Order_ID == GetOrderID);

                    //====================沒有符合條件的直接新增
                    if (existingDetail == null)
                    {
                        InsertToOrderDetail();
                        MessageBox.Show("新增至購物車成功!");
                    }
                    //====================這裡針對Product Quantity+1
                    else
                    {
                        // 更新產品数量
                        existingDetail.Product_Quantity++;

                        // 保存更改到数据库
                        dbContext.SaveChanges();
                        MessageBox.Show("新增至購物車成功!");
                    }
                }
            }
        }

        private void InsertToOrderDetail() {
             var getOrderID = dbContext.Shop_Order_Total_Table.FirstOrDefault(o => o.Member_ID == LoggedInUser.ID && o.Order_Status_ID == 1);

            GetOrderID = getOrderID.Order_ID;

            //MessageBox.Show("GetOrderID = " + GetOrderID);

            Shop_Order_Detail_Table orderDetail = new Shop_Order_Detail_Table
            {
                Order_ID = GetOrderID, //抓資料表的ID
                Product_ID = getProductId, //抓點擊的商品ID
                Product_Quantity = 1,
            };

            //=============寫入資料庫
            dbContext.Shop_Order_Detail_Table.Add(orderDetail);
            dbContext.SaveChanges();
        }



        public class OrderTotal
        {
            public int Member_ID { get; set; }
            public DateTime Order_Creation_Date { get; set; }
            public DateTime Last_Update_Time { get; set; }
            public int Address_ID { get; set; }
            public string Recipient_Address { get; set; }
            public string Recipient_Name { get; set; }
            public string Recipient_Phone { get; set; }
            public int Order_Status_ID { get; set; }
            public int Payment_Method_ID { get; set; }
            public int Coupon_ID { get; set; }
        }

        public class OrderDetail
        {
            public int Order_ID { get; set; }
            public int Product_ID { get; set; }
            public int Product_Quantity { get; set; }
            public int Order_Detail_ID { get; set; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // 觸發Button的Click事件
            button3.PerformClick();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(228, 187, 151); ;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = defaultBackColor;
        }
    }
}
