using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCha
{
    public class CarttoBill
    {
        public string productName { get; set; }
        public decimal productPrice { get; set; }
        public string productCount { get; set; }

        //
        public static decimal CartTotal = 0;

        public static decimal Points = 0;
        public static decimal PointsValue = 0;

        public static decimal Shippment = 80;
        public static decimal Discount = 0;
        public static decimal OrderTotal = 0;

        //最高只能折抵10%
        public static decimal MaxPointsValue = 0;
        public static string PaymentMethod = "";
    }
}
