//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CatCaha.NewFolder1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Game_1on1MessageData
    {
        public int MessageID { get; set; }
        public int DialogueID { get; set; }
        public Nullable<int> SenderID { get; set; }
        public Nullable<int> ReceiverID { get; set; }
        public string ReceiverContent { get; set; }
        public Nullable<System.DateTime> SentTime { get; set; }
        public Nullable<int> Group_ID { get; set; }
    
        public virtual Shop_Member_Info Shop_Member_Info { get; set; }
        public virtual Shop_Member_Info Shop_Member_Info1 { get; set; }
    }
}
