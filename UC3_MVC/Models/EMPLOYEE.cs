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
    
    public partial class EMPLOYEE
    {
        public EMPLOYEE()
        {
            this.CLAIM = new HashSet<CLAIM>();
            this.CLAIM1 = new HashSet<CLAIM>();
        }
    
        public int ID { get; set; }
        public string EMP_FIRSTNAME { get; set; }
        public string EMP_LASTNAME { get; set; }
        public Nullable<int> CONTACT_INFO_ID { get; set; }
        public Nullable<int> DEPARTMENT_ID { get; set; }
        public Nullable<int> AUDIT_INFO { get; set; }
    
        public virtual AUDIT_INFO AUDIT_INFO1 { get; set; }
        public virtual ICollection<CLAIM> CLAIM { get; set; }
        public virtual ICollection<CLAIM> CLAIM1 { get; set; }
        public virtual CONTACT_INFO CONTACT_INFO { get; set; }
        public virtual DEPARTMENT DEPARTMENT { get; set; }
    }
}