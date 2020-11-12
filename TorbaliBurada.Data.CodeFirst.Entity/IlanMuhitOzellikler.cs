namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.IlanMuhitOzellikler")]
    public partial class IlanMuhitOzellikler : EntityBase<int>
    {
      //  public int Id { get; set; }

        public int? EmlakIlanID { get; set; }

        [StringLength(10)]
        public string MuhitOzellikler { get; set; }

        public virtual IlanIlanlar IlanIlanlar { get; set; }
    }
}
