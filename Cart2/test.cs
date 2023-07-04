using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttonHelper
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();

            
        }
            CatChaEntities dbContext = new CatChaEntities();

        private void test_Load(object sender, EventArgs e)
        {
            var test = (from o in this.dbContext.Shop_Order_Total_Table.AsEnumerable()
                        where o.Member_ID == 1 /*&& o.Order_Status_ID == 1*/
                        select o).ToList();
            this.dataGridView1.DataSource = test;

            var test2 = (from o in this.dbContext.Shop_Member_Coupon_Data.AsEnumerable()
                        where o.Member_ID == 1 /*&& o.Order_Status_ID == 1*/
                        select o).ToList();
            this.dataGridView2.DataSource = test2;

            var test3= (from o in this.dbContext.Shop_Member_Info.AsEnumerable()
                        where o.Member_ID == 1 /*&& o.Order_Status_ID == 1*/
                        select o).ToList();
            this.dataGridView3.DataSource = test3;


        }

        private void btnClearAllUpdate_Click(object sender, EventArgs e)
        {
            var back1 = from o in this.dbContext.Shop_Order_Total_Table.AsEnumerable()
                        where o.Order_ID == 2
                        select o;
           foreach(var i in back1)
            {
                i.Payment_Method_ID = null;
                i.Order_Status_ID = 1;
                i.Recipient_Name = null;
                i.Recipient_Phone = null;
                i.Recipient_Address = null;
                i.Coupon_ID = null;
                i.Address_ID = null;

            }
                
            

            var back2 = (from c in this.dbContext.Shop_Member_Coupon_Data.AsEnumerable()
                         where c.Member_ID == 1 /*&& o.Order_Status_ID == 1*/
                         select c);
            foreach ( var i in back2) 
            {
                i.Coupon_Status_ID= false;
            }

            var back3 = (from o in this.dbContext.Shop_Member_Info.AsEnumerable()
                         where o.Member_ID == 1 /*&& o.Order_Status_ID == 1*/
                         select o);
            foreach ( var i in back3)
            {
                i.Loyalty_Points = 3;

            }


            this.dbContext.SaveChanges();
            //先清空
            this.dataGridView1.DataSource = null;
            this.dataGridView2.DataSource = null;
            this.dataGridView3.DataSource = null;
            //再查詢
            this.dataGridView1.DataSource = back1.ToList();
            this.dataGridView2.DataSource=back2.ToList();
            this.dataGridView3.DataSource=back3.ToList();

        }
    }
}
