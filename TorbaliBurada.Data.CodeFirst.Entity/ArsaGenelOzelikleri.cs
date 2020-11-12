namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.ArsaGenelOzelikleri")]
    public partial class ArsaGenelOzelikleri : EntityBase<int>
    {
      //  public int Id { get; set; }

        [StringLength(50)]
        public string ArsaGenelOzellik { get; set; }
    }
}
