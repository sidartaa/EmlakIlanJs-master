namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.ArsaKonumu")]
    public partial class ArsaKonumu : EntityBase<int>
    {
      //  public int Id { get; set; }

        [StringLength(50)]
        public string ArsaKonum { get; set; }
    }
}
