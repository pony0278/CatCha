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
    
    public partial class Shop_會員折價券資料表
    {
        public int 會員ID { get; set; }
        public int 優惠券ID { get; set; }
        public int 優惠券狀態ID { get; set; }
        public int 會員持有優惠券資料ID { get; set; }
    
        public virtual Shop_會員資訊 Shop_會員資訊 { get; set; }
        public virtual Shop_優惠券使用狀態表 Shop_優惠券使用狀態表 { get; set; }
        public virtual Shop_優惠券總表 Shop_優惠券總表 { get; set; }
    }
}
