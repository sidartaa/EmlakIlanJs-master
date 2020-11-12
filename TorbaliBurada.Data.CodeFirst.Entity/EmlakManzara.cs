namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.EmlakManzara")]
    public partial class EmlakManzara : EntityBase<int>
    {
       // public int Id { get; set; }

        [StringLength(10)]
        public string Manzara { get; set; }
    }
}
