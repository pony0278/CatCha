using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCaha.ProductsList
{
    public abstract class ListData<T> where T : ProductsProperties
    {

        public abstract List<T> GetProducts();
    }
}
