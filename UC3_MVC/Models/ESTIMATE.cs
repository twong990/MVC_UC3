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
    
    public partial class ESTIMATE
    {
        public int ID { get; set; }
        public Nullable<int> CLAIM_ID { get; set; }
        public Nullable<decimal> ESTIMATE_AMT { get; set; }
        public Nullable<System.DateTime> ESTIMATE_DATE { get; set; }
        public Nullable<System.DateTime> EXPIRE_DATE { get; set; }
        public Nullable<int> INSPECTION_ID { get; set; }
        public Nullable<int> AUDIT_INFO_ID { get; set; }
        public Nullable<bool> APPROVE { get; set; }
    
        public virtual CLAIM CLAIM { get; set; }
        public virtual INSPECTION INSPECTION { get; set; }
    }
}