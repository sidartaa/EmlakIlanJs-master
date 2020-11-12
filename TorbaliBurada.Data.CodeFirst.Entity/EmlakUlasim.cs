namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.EmlakUlasim")]
    public partial class EmlakUlasim : EntityBase<int>
    {
      //  public int Id { get; set; }

        [StringLength(50)]
        public string Ulasim { get; set; }
    }
}
