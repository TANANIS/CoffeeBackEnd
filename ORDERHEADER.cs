//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoffeeBackEnd20221026
{
    using System;
    using System.Collections.Generic;
    
    public partial class ORDERHEADER
    {
        public string OrderId { get; set; }
        public int ID { get; set; }
        public string CustomerID { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public string Payment { get; set; }
        public Nullable<int> Total { get; set; }
        public string ShipStatus { get; set; }
        public string CreateUser { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string Status { get; set; }
    }
}
