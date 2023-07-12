using CatCaha.ProductsList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatCaha.NewFolder1;
using CatChaForms;

namespace CatCaha.UserDataSouce
{
    public interface IUserProperties
    {
        // Interface properties and methods
        string Name { get; set; }
        int CatCoin { get; set; }
        int MemberID { get; set; }
        string CharacterName { get; set; }
        int LoyaltyPoints { get; set; }

        void UpdateCatCoin(int money, IProductsProperties product);
        void UpdateLoyaltyPoints(int money, IProductsProperties product);
    }

    public class UserProperties : IUserProperties
    {
        project123Entities cat = new project123Entities();
        public string Name { get; set; }
        public int CatCoin { get; set; }
        public int MemberID { get; set; }
        public string CharacterName { get; set; }
        public int LoyaltyPoints { get; set; }

        public void UpdateCatCoin(int money, IProductsProperties product)
        {
            this.CatCoin = money;
            updateMoney(money , product);
        }
        public void UpdateLoyaltyPoints(int money, IProductsProperties product)
        {
            this.LoyaltyPoints = money;
            updateMoney(money, product);
        }
        public void updateMoney(int newMoney, IProductsProperties product)  // 將 product 作為參數傳入
        {
            var ID = LoggedInUser.ID;
            var user = cat.Shop_Member_Info.FirstOrDefault(u => u.Member_ID == ID);
            if (user != null)  // 如果找到了該用戶
            {
                var newPurchase = new Game_Item_Purchase_Record  // 使用實際的類型來創建新的購買記錄
                {
                    Member_ID = user.Member_ID,
                    Character_Name = user.Character_Name,
                    Product_ID = product.ProductID
                };
                cat.Game_Item_Purchase_Record.Add(newPurchase);  // 將新的購買記錄加到 Game_Item_Purchase_Record 數據集中
                user.Cat_Coin_Quantity = newMoney;  // 更新用戶的錢
                cat.SaveChanges();  // 儲存變更到資料庫
            }
        }

        public UserProperties(UserData userData)
        {
            Name = userData.Name;
            CatCoin = userData.catcoin;
            MemberID = userData.MemberID;
            CharacterName = userData.CharacterName;
            LoyaltyPoints = userData.LoyaltyPoints;
        }
    }
}
