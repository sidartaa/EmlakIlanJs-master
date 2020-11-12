namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.EmlakKategoriler")]
    public partial class EmlakKategoriler : EntityBase<int>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmlakKategoriler()
        {
            IlanIlanlar = new HashSet<IlanIlanlar>();
            MusteriList = new HashSet<MusteriList>();
        }

       // public int Id { get; set; }

        [StringLength(50)]
        public string KategoriAd { get; set; }

        public int? ParentID { get; set; }

        [StringLength(50)]
        public string Icon { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Keyword { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [Column(TypeName = "text")]
        public string Aciklama { get; set; }

        [StringLength(10)]
        public string Durum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IlanIlanlar> IlanIlanlar { get; set; }
        public virtual ICollection<MusteriList> MusteriList { get; set; }
    }
}
