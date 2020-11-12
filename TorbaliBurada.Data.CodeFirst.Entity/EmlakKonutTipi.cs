namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.EmlakKonutTipi")]
    public partial class EmlakKonutTipi : EntityBase<int>
    {
        // public int Id { get; set; }
        public EmlakKonutTipi()
        {
            IlanKonutTipiOzellikler = new HashSet<IlanKonutTipiOzellikler>();
        }
        [StringLength(50)]
        public string KonutTipi { get; set; }
        public virtual ICollection<IlanKonutTipiOzellikler> IlanKonutTipiOzellikler { get; set; }
    }
}
