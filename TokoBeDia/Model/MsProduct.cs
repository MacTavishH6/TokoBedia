//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TokoBeDia.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class MsProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MsProduct()
        {
            this.TrDetailTransactions = new HashSet<TrDetailTransaction>();
        }
    
        public int ID { get; set; }
        public int ProductTypeID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Stock { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrDetailTransaction> TrDetailTransactions { get; set; }
    }
}
