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
    
    public partial class Game_Achievement_List
    {
        public int Achievement_ID { get; set; }
        public string Achievement_Name { get; set; }
        public Nullable<int> Achievement_Reward_ID { get; set; }
        public Nullable<int> Achievement_Condition_ID { get; set; }
    
        public virtual Game_Task_Condition_Data Game_Task_Condition_Data { get; set; }
        public virtual Game_Achievement_Reward_List Game_Achievement_Reward_List { get; set; }
    }
}
