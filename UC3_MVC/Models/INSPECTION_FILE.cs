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
    
    public partial class INSPECTION_FILE
    {
        public int ID { get; set; }
        public Nullable<int> INSPECTION_ID { get; set; }
        public Nullable<int> FILE_ID { get; set; }
        public Nullable<int> AUDIT_INFO_ID { get; set; }
    
        public virtual AUDIT_INFO AUDIT_INFO { get; set; }
        public virtual FILE FILE { get; set; }
        public virtual INSPECTION INSPECTION { get; set; }
    }
}