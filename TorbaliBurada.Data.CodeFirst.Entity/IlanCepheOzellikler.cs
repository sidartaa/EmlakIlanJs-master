namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.IlanCepheOzellikler")]
    public partial class IlanCepheOzellikler : EntityBase<int>
    {
       // public int Id { get; set; }

        public int? EmlakIlanID { get; set; }

        [StringLength(50)]
        public string DisOzellik { get; set; }

        public virtual IlanIlanlar IlanIlanlar { get; set; }
    }
}
