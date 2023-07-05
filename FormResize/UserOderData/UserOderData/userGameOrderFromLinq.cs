//using CatCaha.ProductsList;
//using CatCaha.UserDataSouce;
using FormResize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatCaha.ZongHanCompoents.UserOderData
{
    public class userGameOrderFromLinq
    {
       

        貓抓抓Entities2 dbContext = new 貓抓抓Entities2();
        
        public List<userGameOrder> GetAllOder()
        {
            
            var user = dbContext.Game_Item_Purchase_Record.ToArray();
            return user.Select(u =>
            {
                DateTime dateTime;
                if (DateTime.TryParse(u.Purchase_Time, out dateTime))
                {
                    return new userGameOrder
                    {
                        MemberID = (int)u.Member_ID,
                        ProductID = (int)u.Product_ID,
                        CharaterName = u.Character_Name,
                        PurchaseTime = dateTime,
                        ItemName = u.Item_Name,
                        ItemPurchaseRecordID = u.Game_Item_Purchase_Record_ID
                        
                    };
                }
                else
                {
                    return new userGameOrder();
                }
            }).ToList();
        }


        public List<userGameOrder> GetAllOderWithPic()
        {

            var user = dbContext.Game_Item_Purchase_Record.ToArray();
            var image = dbContext.Game_Product_Total.ToDictionary(i => i.Product_ID);
            return user.Select(u =>
            {
                DateTime dateTime;
                if (DateTime.TryParse(u.Purchase_Time, out dateTime))
                {
                    var correspondingProduct = image[(int)u.Product_ID];  // 找到對應的產品
                    return new userGameOrder
                    {
                        MemberID = (int)u.Member_ID,
                        ProductID = (int)u.Product_ID,
                        CharaterName = u.Character_Name,
                        PurchaseTime = dateTime,
                        ItemName = u.Item_Name,
                        ItemPurchaseRecordID = u.Game_Item_Purchase_Record_ID,
                        ProductPic = correspondingProduct.Product_Image  // 使用對應產品的圖片

                    };
                }
                else
                {
                    return new userGameOrder();
                }
            }).ToList();
        }

        public void _SelectAllIncluedPic(DataGridView g) 
        {
            var user = dbContext.Game_Item_Purchase_Record.First().Game_Product_Total.Product_Image;
           
            

        }
        public List<userGameOrder> oderbyTime()
        {
            return GetAllOder().OrderByDescending(t => t.PurchaseTime).ToList();
        }

    }
}

