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
    using System;
    using System.Collections.Generic;
    
    public partial class EmlakKategoriler:EntityBase<int>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmlakKategoriler()
        {
            this.IlanIlanlar = new HashSet<IlanIlanlar>();
        }
    
        //public int Id { get; set; }
        public string KategoriAd { get; set; }
        public Nullable<int> ParentID { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Keyword { get; set; }
        public string Description { get; set; }
        public string Aciklama { get; set; }
        public string Durum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IlanIlanlar> IlanIlanlar { get; set; }
    }
}
