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
    
    public partial class MEDIA_TYPE
    {
        public MEDIA_TYPE()
        {
            this.FILE = new HashSet<FILE>();
        }
    
        public string MEDIA_TYPE_CODE { get; set; }
        public string MEDIA_TYPE_DESC { get; set; }
    
        public virtual ICollection<FILE> FILE { get; set; }
    }
}
