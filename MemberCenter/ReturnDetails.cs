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

namespace CatCaha
{
    public partial class ReturnDetails : Form
    {
        public ReturnDetails(int data)
        {
            InitializeComponent();

            now_Order_ID = data;

            prepareMaterials();
        }

        private void prepareMaterials()
        {
            try
            {
                var q = from p in dbContext.Shop_Return_Data_Table
                      where p.Order_ID == now_Order_ID
                      select p;

                var item = q.FirstOrDefault();

                textBox2.Text = item.Shop_Return_Status_Data_Table.Status_Name;
                textBox3.Text = item.Return_Date.ToString();
                textBox1.Text = item.Shop_Return_Reason_Data_Table.Return_Reason;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int now_Member_ID, now_Order_ID;
        ProjectsModel dbContext = new ProjectsModel();
        //放在類別中供各地方可使用全域，先讓dbContext取得資料

        //傳遞資料
        public int DataProperty { get; set; }
    }
}
