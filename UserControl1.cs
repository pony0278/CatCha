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

{
    {

        {
            InitializeComponent();
            this.buyItems = new BuyItems();
            user = user;
            product = product;
            this.Click += UserControl_Click;
            this.button1.Click += Button_Click;
        }

        {

        public string PriceLabelText
        {
            get { return priceLabel.Text; }
            set { priceLabel.Text = value; }
        }



        }

        {
        }
                    else {
                    //有符合條件的就只需要insert到detail
                    //條件：product id 跟 order id是不是有存在，有存在必須累加
                    //沒有則新增一條在明細裡
                    
                    var getOrderID = dbContext.Shop_Order_Total_Table.FirstOrDefault(o => o.Member_ID == LoggedInUser.ID);
                    GetOrderID = getOrderID.Order_ID;

                    // 查詢條件
                    var existingDetail = dbContext.Shop_Order_Detail_Table.FirstOrDefault(o => o.Product_ID == getProductId && o.Order_ID == GetOrderID);

        {
        }

        {

        }

        {
        }
        {
        }

        {
        }
    }
}
