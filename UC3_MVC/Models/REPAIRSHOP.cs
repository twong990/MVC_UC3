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
    
    public partial class REPAIRSHOP
    {
        public REPAIRSHOP()
        {
            this.INSPECTION = new HashSet<INSPECTION>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public Nullable<int> CONTACT_INFO_ID { get; set; }
        public Nullable<bool> ACTIVE { get; set; }
        public Nullable<int> AUDIT_INFO_ID { get; set; }
    
        public virtual AUDIT_INFO AUDIT_INFO { get; set; }
        public virtual CONTACT_INFO CONTACT_INFO { get; set; }
        public virtual ICollection<INSPECTION> INSPECTION { get; set; }
    }
}
