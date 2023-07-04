using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCaha.ProductsList
{
    public interface IProductsProperties
    {
        int ProductID { get; set; }
        string ProductsName { get; set; }
        int ProductsCateoryID { get; set; }
        int ProductsPrice { get; set; }
        string ProductDescription { get; set; }
        Image Image { get; set; }

    }

    public class ProductsProperties:IProductsProperties
    {
        public int ProductID { get; set; }
        public string ProductsName { get; set; }
        public int ProductsCateoryID { get; set; }
        public Image Image { get; set; }
        public int ProductsPrice { get; set; }
        public String ProductDescription { get; set; }  
    }

}
