namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.IlanDisOzellikler")]
    public partial class IlanDisOzellikler : EntityBase<int>
    {
       // public int Id { get; set; }

        public int? EmlakIlanID { get; set; }
        public int? DisOzellikler { get; set; }

        public virtual IlanIlanlar IlanIlanlar { get; set; }
        public virtual EmlakDisOzellikler EmlakDisOzellikler { get; set; }
    }
}
