//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TorbaliBurada.Data.Entities
{
    using System.Collections.Generic;

    public partial class EmlakKatSayisi:EntityBase<int>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmlakKatSayisi()
        {
            this.IlanlarEmlakGenel = new HashSet<IlanlarEmlakGenel>();
        }
    
        //public int Id { get; set; }
        public string KatSayisi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IlanlarEmlakGenel> IlanlarEmlakGenel { get; set; }
    }
}