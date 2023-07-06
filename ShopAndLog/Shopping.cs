using catcha;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CatChaForms.Shopping;
using CatCaha.NewFolder1;


namespace CatChaForms
{
    public partial class Shopping : Form
    {
        public Shopping()
        {
            InitializeComponent();
        }

        ProjectsModel dbContext = new ProjectsModel();
        private void Shopping_Load(object sender, EventArgs e)
        {
            splitContainer1.BackColor = Color.FromArgb(228, 187, 151);
            splitContainer2.BackColor = Color.FromArgb(254, 245, 239);

            ComboBoxSort.SelectedIndex = 0;

            //================類別
            var qq = dbContext.Shop_Product_Category.ToList();

            for (int i = 0; i < qq.Count; i++)
            {
                flowLayoutPanel2.AutoScroll = true;

                LinkLabel x = new LinkLabel();

                //去除底線
                x.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;

                // 设置 LinkLabel 的 ActiveLinkColor 属性为所需的颜色
                x.ActiveLinkColor = Color.FromArgb(157, 92, 99);

                // 设置 LinkLabel 的 LinkColor 属性为所需的颜色
                x.LinkColor = Color.Black;

                // 设置 LinkLabel 的 VisitedLinkColor 属性为所需的颜色
                x.VisitedLinkColor = Color.FromArgb(157, 92, 99);


                x.Text = qq[i].Category_Name;
                x.Tag = qq[i].Product_Category_ID;

                x.Font = new Font("微軟正黑體", 15); // 设置字体为Arial，大小为12

                x.Width = 200;
                x.Height = 70;

                x.LinkClicked += X_LinkClicked;

                this.flowLayoutPanel2.Controls.Add(x);
            }
        }

        private void X_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int LinkLabel = (int)((LinkLabel)sender).Tag; //Product_Category_ID

            var qq = from pt in dbContext.Shop_Product_Total
                     join pc in dbContext.Shop_Product_Category
                     on pt.Product_Category_ID equals pc.Product_Category_ID
                     where pc.Product_Category_ID == LinkLabel
                     select new ProductData
                     {
                         Product_ID = pt.Product_ID,
                         Product_Name = pt.Product_Name,
                         Product_Price = pt.Product_Price,
                         Release_Date = pt.Release_Date,
                     };

            var matchedProducts = qq.ToList();

            flowLayoutPanel1.Controls.Clear();
            GetProductDataFromSource(matchedProducts);
        }

        private void GetProductDataFromSource(List<ProductData> productList)
        {
            foreach (ProductData productData in productList)
            {
                ProductControl productControl = new ProductControl();

                // 设置商品名称
                productControl.NameLabelText = productData.Product_Name;
                // 设置商品上架日期
                productControl.getDate = productData.Release_Date?.ToString("yyyy-MM-dd");
                // 设置商品价格
                productControl.PriceLabelText = string.Format("{0:C0}", productData.Product_Price); // 格式化为货币字符串

                // ----------------------------------------------------------------------------
                List<ProductData> imgString = new List<ProductData>();
                imgString = dbContext.Shop_Product_Image_Table.Where(p => p.Product_ID == productData.Product_ID).Select(p => new ProductData
                {
                    ImageID = p.Product_ID,
                    Image = p.Product_Photo,
                }).ToList();

                for (int i = 0; i < imgString.Count; i++)
                {
                    var img = imgString[i].Image;
                    System.Drawing.Image img_result = (Bitmap)((new ImageConverter()).ConvertFrom(img));
                    productControl.ProductImage = img_result;
                }
                // ----------------------------------------------------------------------------

                productControl.getProductId = productData.Product_ID;

                // 将商品控件添加到 FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(productControl);
            }
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = TextBoxSearch.Text.Trim(); // 获取文本框的内容并去除首尾空格

            var matchedProducts = dbContext.Shop_Product_Total
            .Where(p => p.Product_Name.Contains(searchText))
            .Select(p => new ProductData
            {
                Product_ID = p.Product_ID,
                Product_Name = p.Product_Name,
                Product_Price = p.Product_Price,
                Release_Date = p.Release_Date,

            })
            .ToList();

            // 清空现有的商品控件
            flowLayoutPanel1.Controls.Clear();

            // 显示匹配的商品控件
            GetProductDataFromSource(matchedProducts);

            label2.Text = (searchText == "") ? "" : "共找到" + matchedProducts.Count + "項 符合「 " + searchText + "」的商品";
        }

        private void ComboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            IQueryable<ProductData> query = dbContext.Shop_Product_Total.Select(p => new ProductData
            {
                Product_ID = p.Product_ID,
                Product_Name = p.Product_Name,
                Product_Price = p.Product_Price,
                Remaining_Quantity = p.Remaining_Quantity,
                Release_Date = p.Release_Date
            });

            if (ComboBoxSort.SelectedIndex == 1)
            {
                query = query.OrderByDescending(p => p.Release_Date); //最新商品
            }
            else if (ComboBoxSort.SelectedIndex == 2) // 價格低至高
            {
                query = query.OrderBy(p => p.Product_Price);
            }
            else if (ComboBoxSort.SelectedIndex == 3) // 價格高至低
            {
                query = query.OrderByDescending(p => p.Product_Price);
            }

            var matchedProducts = query.ToList();

            flowLayoutPanel1.Controls.Clear();
            GetProductDataFromSource(matchedProducts);
        }

        public class ProductData
        {
            public int? ImageID { get; set; }
            public byte[] Image { get; set; }
            public string Product_Name { get; set; }
            public int Product_ID { get; set; }
            public int Product_Category_ID { get; set; }
            public string Product_Description { get; set; }
            public decimal? Product_Price { get; set; }
            public string Size { get; set; }
            public string Weight { get; set; }
            public DateTime? Release_Date { get; set; }
            public int Discontinued { get; set; }
            public int? Remaining_Quantity { get; set; }
            public int Supplier_ID { get; set; }
        }

        private void userToolStrip1_Load(object sender, EventArgs e)
        {

        }
    }
}
