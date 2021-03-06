//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SYSTEM_MANAGEMENT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class COMPANY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPANY()
        {
            this.COMPANYS1 = new HashSet<COMPANY>();
            this.DEPARTMENTS = new HashSet<DEPARTMENT>();
            this.WAREHOUSES = new HashSet<Warehouse>();
        }
    
        public string COMPANY_ID { get; set; }
        public string COMPANY_NAME { get; set; }
        public string PARENT_COMPANY { get; set; }
        public int MANAGER { get; set; }
        public string COMPANY_CATEGORY_ID { get; set; }
        public string NOTED { get; set; }
    
        public virtual COMPANY_CATEGORIES COMPANY_CATEGORIES { get; set; }
        public virtual USER USER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPANY> COMPANYS1 { get; set; }
        public virtual COMPANY COMPANY1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEPARTMENT> DEPARTMENTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Warehouse> WAREHOUSES { get; set; }
    }
}
