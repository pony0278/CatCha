//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace buttonHelper
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shop_Member_Info
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shop_Member_Info()
        {
            this.Shop_Common_Address_Data = new HashSet<Shop_Common_Address_Data>();
            this.Shop_Member_Coupon_Data = new HashSet<Shop_Member_Coupon_Data>();
            this.Shop_Order_Total_Table = new HashSet<Shop_Order_Total_Table>();
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
        public virtual ICollection<Shop_Common_Address_Data> Shop_Common_Address_Data { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_Member_Coupon_Data> Shop_Member_Coupon_Data { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_Order_Total_Table> Shop_Order_Total_Table { get; set; }
    }
}