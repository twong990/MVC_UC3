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
    
    public partial class PROBLEM
    {
        public int ID { get; set; }
        public Nullable<int> CLAIM_ID { get; set; }
        public string TYPE { get; set; }
        public Nullable<int> PART { get; set; }
        public string DESCRIPTION { get; set; }
        public string SIDE { get; set; }
        public Nullable<decimal> GOODWILL { get; set; }
        public Nullable<int> PRODUCT_ID { get; set; }
        public Nullable<bool> APPROVED { get; set; }
        public Nullable<int> AUDIT_INFO_ID { get; set; }
        public Nullable<int> WARRANTY_NUMBER { get; set; }
    
        public virtual AUDIT_INFO AUDIT_INFO { get; set; }
        public virtual CLAIM CLAIM { get; set; }
        public virtual PROBLEM_TYPE PROBLEM_TYPE { get; set; }
        public virtual PRODUCT PRODUCT { get; set; }
        public virtual SIDE_CODE SIDE_CODE { get; set; }
        public virtual VEHICLE_PART VEHICLE_PART { get; set; }
        public virtual WARRANTY WARRANTY { get; set; }
    }
}
