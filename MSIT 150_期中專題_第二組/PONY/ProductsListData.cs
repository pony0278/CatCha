using CatCaha.NewFolder1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CatCaha.ProductsList
{
    public class ProductsListData : ListData<ProductsProperties>
    {
        project123Entities cat = new project123Entities();

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

                }).ToList();
        }
        public List<ProductsProperties> GetPriceThan20()
        {
            return GetProducts().Where(t => t.ProductsPrice > 20).ToList();
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
