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
    
    public partial class Shop_Member_Info
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shop_Member_Info()
        {
            this.Game_1on1MessageData = new HashSet<Game_1on1MessageData>();
            this.Game_1on1MessageData1 = new HashSet<Game_1on1MessageData>();
            this.Game_Coin_Exchange_Record = new HashSet<Game_Coin_Exchange_Record>();
            this.Game_Friend_Data = new HashSet<Game_Friend_Data>();
            this.Game_Friend_Data1 = new HashSet<Game_Friend_Data>();
            this.Game_Friend_Data2 = new HashSet<Game_Friend_Data>();
            this.Game_Global_Chat_Data = new HashSet<Game_Global_Chat_Data>();
            this.Game_Member_Task = new HashSet<Game_Member_Task>();
            this.Shop_Common_Address_Data = new HashSet<Shop_Common_Address_Data>();
            this.Shop_Favorite_Data_Table = new HashSet<Shop_Favorite_Data_Table>();
            this.Shop_Member_Complaint_Case = new HashSet<Shop_Member_Complaint_Case>();
            this.Shop_Member_Coupon_Data = new HashSet<Shop_Member_Coupon_Data>();
            this.Shop_Order_Total_Table = new HashSet<Shop_Order_Total_Table>();
            this.Shop_Product_Review_Table = new HashSet<Shop_Product_Review_Table>();
        }
    
        public int Member_ID { get; set; }
        public string Member_Account { get; set; }
        public string Character_Name { get; set; }
        public Nullable<int> Level_ID { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string Email { get; set; }
        public string Phone_Number { get; set; }
        public string Address { get; set; }
        public Nullable<int> Cat_Coin_Quantity { get; set; }
        public Nullable<int> Loyalty_Points { get; set; }
        public Nullable<System.DateTime> Registration_Time { get; set; }
        public Nullable<System.DateTime> Last_Login_Time { get; set; }
        public Nullable<int> Favorite_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Game_1on1MessageData> Game_1on1MessageData { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Game_1on1MessageData> Game_1on1MessageData1 { get; set; }
        public virtual Game_CheckIn Game_CheckIn { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Game_Coin_Exchange_Record> Game_Coin_Exchange_Record { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Game_Friend_Data> Game_Friend_Data { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Game_Friend_Data> Game_Friend_Data1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Game_Friend_Data> Game_Friend_Data2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Game_Global_Chat_Data> Game_Global_Chat_Data { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Game_Member_Task> Game_Member_Task { get; set; }
        public virtual Game_Rank_Data Game_Rank_Data { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_Common_Address_Data> Shop_Common_Address_Data { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_Favorite_Data_Table> Shop_Favorite_Data_Table { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_Member_Complaint_Case> Shop_Member_Complaint_Case { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_Member_Coupon_Data> Shop_Member_Coupon_Data { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_Order_Total_Table> Shop_Order_Total_Table { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_Product_Review_Table> Shop_Product_Review_Table { get; set; }
    }
}
