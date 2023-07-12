using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.IO;
using FormResize;
using CatCaha.NewFolder1;
//TODO..圖片跑太多要包TRYCATCH
namespace 抽卡
{
    public class mixRandomDrow
    {
        int count = 0;
        int x = 0;
        int y = 0;
        public static Image P;
        string prizeN = "";

        bool hasWonPrize = false;
        int couponCount = 0;     // Number of Coupons
        int catCount = 0;        // Number of Cats
        int backgroundCount = 0; // Number of Backgrounds
        int bowlCount = 0;       // Number of Bowls
        int furnitureCount = 0;  // Number of Furniture
        int feedCount = 0;       // Number of Feeds
        int waterCount = 0;      // Number of Waters
        int coinCount = 0;       // Number of Coins

        project123Entities dbContext = new project123Entities();
        Random random = new Random();
        string imagePath = "../../CatPicture/P_coupon.png";
        public class Item
        {
            public string 道具 { get; set; }
            public decimal? 機率 { get; set; }
            public int 道具編號 { get; set; }
            public byte[] 道具圖片 { get; set; }
        }

        public void ItemP(DataGridView g)
        {
            byte[] imageBytes = File.ReadAllBytes(imagePath);
            var q = from p in dbContext.Game_Product_Total
                    where p.Product_Category_ID !=2
                    select new Item { 道具 = p.Product_Name, 機率 = p.Lottery_Probability, 道具編號 = p.Product_ID, 道具圖片 = p.Product_Image };

            var x = from p in dbContext.Shop_Coupon_Total
                    where p.Coupon_ID == 4
                    select new Item { 道具 = p.Coupon_Content, 機率 = (decimal?)0.1, 道具編號 = 1, 道具圖片 = imageBytes };

            var combinedResult = q.Concat(x);
            foreach (var item in combinedResult)
            {
                var cb= q.Concat(x).ToList();
                g.DataSource = cb;
            }
        }

        public void Drow()
        {
            hasWonPrize = false;
            while (!hasWonPrize)
            {
                int randomNumber = random.Next();
                DateTime dt = DateTime.Now;
                long ts = dt.Ticks;
                int baseSeed = (int)(ts % 100000) % Math.Abs(randomNumber);

                int MixResult = ((randomNumber * baseSeed) % 10000);
                int r = random.Next(0, 100);

                // 定義獎品圖片陣列
                string[] prizeImages = new string[]
                {
                    "..//..//Resources\\GamePicture\\P_coupon.png",        // 實體折價券（2%）
                    "..//..//Resources\\GamePicture\\cat_w_sR.gif",        // 貓咪（5%）
                    "..//..//Resources\\GamePicture\\P_background.png",    // 背景（5%）
                    "..//..//Resources\\GamePicture\\P_bowl.png",          // 飯盆（13%）
                    "..//..//Resources\\GamePicture\\P_lamp.png",          // 家具（5%）
                    "..//..//Resources\\GamePicture\\P_food.png",          // 飼料（25%）
                    "..//..//Resources\\GamePicture\\P_water.png",         // 水（25%）
                    "..//..//Resources\\GamePicture\\_catcoin.png"           // 貓幣（20%）
                };

                // 定義獎品圖片對應的位置
                int[] xCoordinates = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
                int[] yCoordinates = new int[] { 1, 1, 1, 2, 2, 3, 3, 3 };

                for (int i = 0; i < prizeImages.Length; i++)
                {
                    if (r < 2 && MixResult < 300 && i == 0)
                    {
                        hasWonPrize = true;
                        x = xCoordinates[i];
                        y = yCoordinates[i];
                        couponCount += 1;
                        P = Image.FromFile(prizeImages[i]);
                        prizeN = "實體折價券";
                        break;
                    }
                    else if ((r > 2 && r < 7) && MixResult < 600 && i == 1)
                    {
                        hasWonPrize = true;
                        x = xCoordinates[i];
                        y = yCoordinates[i];
                        catCount += 1;
                        P = Image.FromFile(prizeImages[i]);
                        prizeN = "活力貓咪";
                        break;
                    }
                    else if ((r > 7 && r < 12) && MixResult < 600 && i == 2)
                    {
                        hasWonPrize = true;
                        x = xCoordinates[i];
                        y = yCoordinates[i];
                        backgroundCount += 1;
                        P = Image.FromFile(prizeImages[i]);
                        prizeN = "背景";
                        break;
                    }
                    else if ((r > 12 && r < 25) && MixResult < 1400 && i == 3)
                    {
                        hasWonPrize = true;
                        x = xCoordinates[i];
                        y = yCoordinates[i];
                        bowlCount += 1;
                        P = Image.FromFile(prizeImages[i]);
                        prizeN = "寵物飯盆";
                        break;
                    }
                    else if ((r > 25 && r < 30) && MixResult < 600 && i == 4)
                    {
                        hasWonPrize = true;
                        x = xCoordinates[i];
                        y = yCoordinates[i];
                        furnitureCount += 1;
                        P = Image.FromFile(prizeImages[i]);
                        prizeN = "檯燈";
                        break;
                    }
                    else if ((r > 30 && r < 55) && MixResult < 2600 && i == 5)
                    {
                        hasWonPrize = true;
                        x = xCoordinates[i];
                        y = yCoordinates[i];
                        feedCount += 1;
                        P = Image.FromFile(prizeImages[i]);
                        prizeN = "寵物飼料";
                        break;
                    }
                    else if ((r > 55 && r < 80) && MixResult < 2600 && i == 6)
                    {
                        hasWonPrize = true;
                        x = xCoordinates[i];
                        y = yCoordinates[i];
                        waterCount += 1;
                        P = Image.FromFile(prizeImages[i]);
                        prizeN = "水";
                        break;
                    }
                    else if ((r > 80 && r < 100) && MixResult < 2100 && i == 7)
                    {
                        hasWonPrize = true;
                        x = xCoordinates[i];
                        y = yCoordinates[i];
                        coinCount += 1;
                        P = Image.FromFile(prizeImages[i]);
                        prizeN = "貓幣";
                        break;
                    }
                }
            }
            count += 1;
        }
        public string prizeName()
        {
            return prizeN;
        }
        public Image getP()
        {
            return P;
        }
        public int Count()
        {
            return count;
        }
        public int getx()
        {
            return x;
        }
        public int gety()
        {
            return y;
        }
        //CouponCount();
        //CatCount();
        //BackGorundCount();
        //BowlCount();
        //FurnitureCount();
        //FeedCount();
        //WaterCount();
        //CoinCount();
        public int CouponCount()
        {
            return couponCount;
        }
        public int CatCount()
        {
            return catCount;
        }
        public int BackGorundCount()
        {
            return backgroundCount;
        }
        public int BowlCount()
        {
            return bowlCount;
        }
        public int FurnitureCount()
        {
            return furnitureCount;
        }
        public int FeedCount()
        {
            return feedCount;
        }
        public int WaterCount()
        {
            return waterCount;
        }
        public int CoinCount()
        {
            return coinCount;
        }
        //實體折價券2%,貓咪3%,背景5%,飯盆10%,家具10%,飼料25%,水%25,貓幣20%
        public void _POPFORMTOCENTER(Form original, Form f) //讓新視窗出現在原窗位置的中間
        {
            f.StartPosition = FormStartPosition.Manual;

            // 計算新表單的位置，使其位於原表單的畫面中央
            int newX = original.Location.X + (original.Width - f.Width) / 2;
            int newY = original.Location.Y + (original.Height - f.Height) / 2;
            f.Location = new Point(newX, newY);

        }
    }

}
