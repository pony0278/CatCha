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
    
    public partial class Game_Shop公告
    {
        public int 公告ID { get; set; }
        public string 公告標題 { get; set; }
        public string 公告內文 { get; set; }
        public byte[] 公告圖片_天_ { get; set; }
        public int 管理員ID { get; set; }
        public System.DateTime 編輯時間 { get; set; }
        public System.DateTime 發布時間 { get; set; }
        public bool 顯示狀態 { get; set; }
        public bool 是否要在遊戲與商城同步顯示 { get; set; }
        public bool 是否不要在遊戲中顯示 { get; set; }
        public bool 是否要變成跑馬燈 { get; set; }
        public bool 是否置頂 { get; set; }
        public int 公告類型ID { get; set; }
        public string 公告圖片_內文_ { get; set; }
    
        public virtual Shop_Game_後臺管理員資料 Shop_Game_後臺管理員資料 { get; set; }
        public virtual 公告類型資料表 公告類型資料表 { get; set; }
    }
}
