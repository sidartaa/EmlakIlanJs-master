namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.ArsaManzara")]
    public partial class ArsaManzara : EntityBase<int>
    {
      //  public int Id { get; set; }

        [StringLength(50)]
        public string ArsaManzarasi { get; set; }
    }
}
