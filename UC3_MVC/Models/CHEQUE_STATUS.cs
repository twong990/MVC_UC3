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
    
    public partial class CHEQUE_STATUS
    {
        public CHEQUE_STATUS()
        {
            this.CHEQUE = new HashSet<CHEQUE>();
        }
    
        public string STATUS_CODE { get; set; }
        public string STATUS_DESC { get; set; }
    
        public virtual ICollection<CHEQUE> CHEQUE { get; set; }
    }
}
