//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UC3_MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ORDER_ITEMS
    {
        public int ID { get; set; }
        public Nullable<int> ORDER_ID { get; set; }
        public Nullable<int> PRODUCT_ID { get; set; }
        public Nullable<decimal> QTY { get; set; }
        public Nullable<decimal> PRICE_PER_UNIT { get; set; }
        public Nullable<decimal> DISCOUNT { get; set; }
        public Nullable<int> AUDIT_INFO_ID { get; set; }
    
        public virtual AUDIT_INFO AUDIT_INFO { get; set; }
        public virtual ORDER ORDER { get; set; }
        public virtual PRODUCT PRODUCT { get; set; }
    }
}
