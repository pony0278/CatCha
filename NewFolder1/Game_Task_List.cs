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
    
    public partial class Game_Task_List
    {
        public int Task_ID { get; set; }
        public string Task_Name { get; set; }
        public string Task_Description { get; set; }
        public decimal Task_Reward { get; set; }
        public int Task_Condition_ID { get; set; }
    
        public virtual Game_Member_Task Game_Member_Task { get; set; }
        public virtual Game_Task_Condition_Data Game_Task_Condition_Data { get; set; }
    }
}
