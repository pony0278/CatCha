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
    
    public partial class Shop_退換貨資料表
    {
        public int 訂單ID { get; set; }
        public int 退換貨原因ID { get; set; }
        public int 處理狀態ID { get; set; }
        public System.DateTime 退換貨日期 { get; set; }
    
        public virtual Shop_訂單總表 Shop_訂單總表 { get; set; }
        public virtual Shop_退換貨原因資料表 Shop_退換貨原因資料表 { get; set; }
        public virtual Shop_退換貨處理狀態資料表 Shop_退換貨處理狀態資料表 { get; set; }
    }
}
