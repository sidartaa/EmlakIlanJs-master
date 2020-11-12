namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.IlanUlasimOzellikler")]
    public partial class IlanUlasimOzellikler : EntityBase<int>
    {
       // public int Id { get; set; }

        public int? EmlakIlanID { get; set; }

        [StringLength(100)]
        public string UlasimOzellikler { get; set; }

        public virtual IlanIlanlar IlanIlanlar { get; set; }
    }
}
