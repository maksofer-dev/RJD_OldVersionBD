//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RJD_IntangibleValuesAccounting
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            this.AccountingIntangibleValues = new HashSet<AccountingIntangibleValue>();
        }
    
        public int BillID { get; set; }
        public string BillName { get; set; }
        public string BillHolder { get; set; }
        public string BillNumber { get; set; }
        public string BillINN { get; set; }
        public string BillBIK { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountingIntangibleValue> AccountingIntangibleValues { get; set; }
    }
}
