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
    
    public partial class SIDE_CODE
    {
        public SIDE_CODE()
        {
            this.PROBLEM = new HashSet<PROBLEM>();
            this.VEHICLE_PART = new HashSet<VEHICLE_PART>();
        }
    
        public string SIDE_CODE1 { get; set; }
        public string SIDE_DESC { get; set; }
    
        public virtual ICollection<PROBLEM> PROBLEM { get; set; }
        public virtual ICollection<VEHICLE_PART> VEHICLE_PART { get; set; }
    }
}