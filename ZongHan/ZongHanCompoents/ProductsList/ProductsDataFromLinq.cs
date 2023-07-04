using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatCaha.ZongHan;


namespace CatCaha.ProductsList
{
    public class ProductsDataFromLinq : ListData<ProductsProperties>
    {
        CatChaEntities cat = new CatChaEntities();

        public override List<ProductsProperties> GetProducts()
        {
            var products = cat.Game_Product_Total.ToArray();
            return products.Select(
                c => new ProductsProperties
            {
                Image = ConvertToImage(c.Product_Image),
                ProductsName = c.Product_Name,
                ProductsPrice = (int)c.Product_Price,
                ProductDescription = c.Product_Description,
                ProductID = c.Product_ID,
                ProductsCateoryID = (int)c.Product_Category_ID,

                }).ToList();
        }
        public List<ProductsProperties> GetProductID1()
        {
            return GetProducts().Where(t => t.ProductsCateoryID == 1).ToList();
        }
        public List<ProductsProperties> GetProductID2()
        {
            return GetProducts().Where(t => t.ProductsCateoryID == 2).ToList();
        }
        public List<ProductsProperties> GetProductID3()
        {
            return GetProducts().Where(t => t.ProductsCateoryID == 3).ToList();
        }
        public List<ProductsProperties> GetProductID4()
        {
            return GetProducts().Where(t => t.ProductsCateoryID == 4).ToList();
        }

        private Image ConvertToImage(byte[] data)
        {
            if (data == null || data.Length == 0) return null;
            using (var ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
