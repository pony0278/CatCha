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
    
    public partial class Shop_Game_後臺管理員資料
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shop_Game_後臺管理員資料()
        {
            this.Game_Shop公告 = new HashSet<Game_Shop公告>();
            this.Game_Shop部落格資料表 = new HashSet<Game_Shop部落格資料表>();
            this.Shop_回覆資料表 = new HashSet<Shop_回覆資料表>();
        }
    
        public int 管理員ID { get; set; }
        public string 管理員帳號 { get; set; }
        public string 管理員密碼 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Game_Shop公告> Game_Shop公告 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Game_Shop部落格資料表> Game_Shop部落格資料表 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_回覆資料表> Shop_回覆資料表 { get; set; }
    }
}
