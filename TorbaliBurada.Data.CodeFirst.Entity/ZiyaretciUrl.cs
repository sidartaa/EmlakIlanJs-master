namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.ZiyaretciUrl")]
    public partial class ZiyaretciUrl
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Ip { get; set; }

        [StringLength(350)]
        public string RefererUrl { get; set; }

        [StringLength(550)]
        public string GetUrl { get; set; }

        [StringLength(50)]
        public string Browser { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Tarih { get; set; }
    }
}
