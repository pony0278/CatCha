//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CatCaha
{
    using System;
    using System.Collections.Generic;
    
    public partial class Game_背包物品總表
    {
        public int 會員ID { get; set; }
        public int 商品ID { get; set; }
        public int 扭蛋ID { get; set; }
    
        public virtual Game_扭蛋紀錄表 Game_扭蛋紀錄表 { get; set; }
        public virtual Game_物品購買紀錄表 Game_物品購買紀錄表 { get; set; }
        public virtual Shop_會員資訊 Shop_會員資訊 { get; set; }
    }
}
