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
    
    public partial class Shop_Product_Total
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shop_Product_Total()
        {
            this.Shop_Favorite_Data_Table = new HashSet<Shop_Favorite_Data_Table>();
            this.Shop_Order_Detail_Table = new HashSet<Shop_Order_Detail_Table>();
            this.Shop_Product_Image_Table = new HashSet<Shop_Product_Image_Table>();
            this.Shop_Product_Review_Table = new HashSet<Shop_Product_Review_Table>();
            this.Shop_Favorite_Data_Table1 = new HashSet<Shop_Favorite_Data_Table>();
        }
    
        public string Product_Name { get; set; }
        public int Product_ID { get; set; }
        public Nullable<int> Product_Category_ID { get; set; }
        public string Product_Description { get; set; }
        public Nullable<decimal> Product_Price { get; set; }
        public string Size { get; set; }
        public string Weight { get; set; }
        public Nullable<System.DateTime> Release_Date { get; set; }
        public Nullable<bool> Discontinued { get; set; }
        public Nullable<int> Remaining_Quantity { get; set; }
        public Nullable<int> Supplier_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_Favorite_Data_Table> Shop_Favorite_Data_Table { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_Order_Detail_Table> Shop_Order_Detail_Table { get; set; }
        public virtual Shop_Product_Category Shop_Product_Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_Product_Image_Table> Shop_Product_Image_Table { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_Product_Review_Table> Shop_Product_Review_Table { get; set; }
        public virtual Shop_Product_Supplier Shop_Product_Supplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_Favorite_Data_Table> Shop_Favorite_Data_Table1 { get; set; }
    }
}
