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
    
    public partial class FILE
    {
        public FILE()
        {
            this.INSPECTION_FILE = new HashSet<INSPECTION_FILE>();
        }
    
        public int ID { get; set; }
        public string FILE_NAME { get; set; }
        public Nullable<int> FILE_SIZE { get; set; }
        public string FILE_TYPE { get; set; }
        public string MEDIA_TYPE { get; set; }
        public string FILE_PATH { get; set; }
        public Nullable<int> AUDIT_INFO_ID { get; set; }
    
        public virtual AUDIT_INFO AUDIT_INFO { get; set; }
        public virtual MEDIA_TYPE MEDIA_TYPE1 { get; set; }
        public virtual ICollection<INSPECTION_FILE> INSPECTION_FILE { get; set; }
    }
}
