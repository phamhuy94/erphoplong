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
    
    public partial class PRODUCT_CATEGORIES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCT_CATEGORIES()
        {
            this.PRODUCT_CATEGORY_DETAILS = new HashSet<PRODUCT_CATEGORY_DETAILS>();
            this.PURCHASE_ORDER = new HashSet<PURCHASE_ORDER>();
            this.SUPPLIERS = new HashSet<SUPPLIER>();
        }
    
        public string MA_NHOM_HANG { get; set; }
        public string TEN_NHOM_HANG { get; set; }
        public string MO_TA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCT_CATEGORY_DETAILS> PRODUCT_CATEGORY_DETAILS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PURCHASE_ORDER> PURCHASE_ORDER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUPPLIER> SUPPLIERS { get; set; }
    }
}
