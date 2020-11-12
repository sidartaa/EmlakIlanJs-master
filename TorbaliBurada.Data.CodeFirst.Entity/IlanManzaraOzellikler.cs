namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.IlanManzaraOzellikler")]
    public partial class IlanManzaraOzellikler : EntityBase<int>
    {
       // public int Id { get; set; }

        public int? EmlakIlanID { get; set; }

        [StringLength(100)]
        public string ManzaraOzellikler { get; set; }

        public virtual IlanIlanlar IlanIlanlar { get; set; }
    }
}
