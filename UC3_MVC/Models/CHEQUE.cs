//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UC3_MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHEQUE
    {
        public CHEQUE()
        {
            this.CLAIM = new HashSet<CLAIM>();
            this.PAYMENT = new HashSet<PAYMENT>();
        }
    
        public int ID { get; set; }
        public string CHEQUE_NUMBER { get; set; }
        public string PAYTO { get; set; }
        public Nullable<System.DateTime> CHEQUE_DATE { get; set; }
        public Nullable<decimal> CHEQUE_AMT { get; set; }
        public string CHEQUE_STATUS { get; set; }
        public Nullable<int> AUDIT_INFO_ID { get; set; }
    
        public virtual CHEQUE_STATUS CHEQUE_STATUS1 { get; set; }
        public virtual ICollection<CLAIM> CLAIM { get; set; }
        public virtual ICollection<PAYMENT> PAYMENT { get; set; }
    }
}
