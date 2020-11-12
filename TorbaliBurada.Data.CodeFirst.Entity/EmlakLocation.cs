namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.EmlakLocation")]
    public partial class EmlakLocation : EntityBase<int>
    {
       
        public EmlakLocation()
        {
            // IlanAdresler = new HashSet<IlanAdresler>();
            IlanIlanlar = new HashSet<IlanIlanlar>();
            MusteriList = new HashSet<MusteriList>();
        }

       // public int Id { get; set; }

        [StringLength(50)]
        public string LocationName { get; set; }

        public int? ParentID { get; set; }

        public int? PlakaID { get; set; }

        [StringLength(50)]
        public string Logo { get; set; }

        public string Aciklama { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<IlanAdresler> IlanAdresler { get; set; }
        public virtual ICollection<IlanIlanlar> IlanIlanlar { get; set; }
        public virtual ICollection<MusteriList> MusteriList { get; set; }
    }
}
