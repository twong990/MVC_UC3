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
    
    public partial class AUDIT_INFO
    {
        public AUDIT_INFO()
        {
            this.AGREEMENT_PRODUCT = new HashSet<AGREEMENT_PRODUCT>();
            this.CLAIM = new HashSet<CLAIM>();
            this.CLIENT = new HashSet<CLIENT>();
            this.CONTACT_INFO = new HashSet<CONTACT_INFO>();
            this.DEALERSHIP_AGREEMENT = new HashSet<DEALERSHIP_AGREEMENT>();
            this.DEALERSHIP = new HashSet<DEALERSHIP>();
            this.DEALERSHIP_PRODUCT = new HashSet<DEALERSHIP_PRODUCT>();
            this.EMPLOYEE = new HashSet<EMPLOYEE>();
            this.FILE = new HashSet<FILE>();
            this.INSPECTION = new HashSet<INSPECTION>();
            this.INSPECTION_FILE = new HashSet<INSPECTION_FILE>();
            this.INVOICE = new HashSet<INVOICE>();
            this.INVOICE_ORDER = new HashSet<INVOICE_ORDER>();
            this.ORDER = new HashSet<ORDER>();
            this.ORDER_ITEMS = new HashSet<ORDER_ITEMS>();
            this.PAYMENT = new HashSet<PAYMENT>();
            this.PROBLEM = new HashSet<PROBLEM>();
            this.PRODUCT = new HashSet<PRODUCT>();
            this.REPAIRSHOP = new HashSet<REPAIRSHOP>();
            this.VEHICLE = new HashSet<VEHICLE>();
            this.VEHICLE_OWNER = new HashSet<VEHICLE_OWNER>();
            this.WARRANTY = new HashSet<WARRANTY>();
            this.WARRANTY_TYPE = new HashSet<WARRANTY_TYPE>();
        }
    
        public int ID { get; set; }
        public System.DateTime UPDATE_TS { get; set; }
        public string UPDATED_BY { get; set; }
        public System.DateTime CREATED_DATE { get; set; }
        public string CREATED_BY { get; set; }
    
        public virtual ICollection<AGREEMENT_PRODUCT> AGREEMENT_PRODUCT { get; set; }
        public virtual ICollection<CLAIM> CLAIM { get; set; }
        public virtual ICollection<CLIENT> CLIENT { get; set; }
        public virtual ICollection<CONTACT_INFO> CONTACT_INFO { get; set; }
        public virtual ICollection<DEALERSHIP_AGREEMENT> DEALERSHIP_AGREEMENT { get; set; }
        public virtual ICollection<DEALERSHIP> DEALERSHIP { get; set; }
        public virtual ICollection<DEALERSHIP_PRODUCT> DEALERSHIP_PRODUCT { get; set; }
        public virtual ICollection<EMPLOYEE> EMPLOYEE { get; set; }
        public virtual ICollection<FILE> FILE { get; set; }
        public virtual ICollection<INSPECTION> INSPECTION { get; set; }
        public virtual ICollection<INSPECTION_FILE> INSPECTION_FILE { get; set; }
        public virtual ICollection<INVOICE> INVOICE { get; set; }
        public virtual ICollection<INVOICE_ORDER> INVOICE_ORDER { get; set; }
        public virtual ICollection<ORDER> ORDER { get; set; }
        public virtual ICollection<ORDER_ITEMS> ORDER_ITEMS { get; set; }
        public virtual ICollection<PAYMENT> PAYMENT { get; set; }
        public virtual ICollection<PROBLEM> PROBLEM { get; set; }
        public virtual ICollection<PRODUCT> PRODUCT { get; set; }
        public virtual ICollection<REPAIRSHOP> REPAIRSHOP { get; set; }
        public virtual ICollection<VEHICLE> VEHICLE { get; set; }
        public virtual ICollection<VEHICLE_OWNER> VEHICLE_OWNER { get; set; }
        public virtual ICollection<WARRANTY> WARRANTY { get; set; }
        public virtual ICollection<WARRANTY_TYPE> WARRANTY_TYPE { get; set; }
    }
}
