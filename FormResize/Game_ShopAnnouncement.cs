//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormResize
{
    using System;
    using System.Collections.Generic;
    
    public partial class Game_ShopAnnouncement
    {
        public int AnnouncementID { get; set; }
        public string AnnouncementTitle { get; set; }
        public string AnnouncementContent { get; set; }
        public byte[] AnnouncementImage_Header_ { get; set; }
        public int AdminID { get; set; }
        public System.DateTime EditTime { get; set; }
        public System.DateTime PublishTime { get; set; }
        public bool DisplayOrNot { get; set; }
        public bool SyncWithGameAndShopDisplay { get; set; }
        public bool HideIn_gameDisplay { get; set; }
        public bool ConvertToMarquee { get; set; }
        public bool PinToTop { get; set; }
        public int AnnouncementType_ID { get; set; }
        public string AnnouncementImage_Content_ { get; set; }
    
        public virtual Announcement_Type_datum Announcement_Type_Data { get; set; }
        public virtual Shop_Game_Admin_Data Shop_Game_Admin_Data { get; set; }
    }
}
