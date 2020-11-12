namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.Etiketler")]
    public partial class Etiketler
    {
        [Key]
        public int EtiketID { get; set; }

        [StringLength(150)]
        public string Etiket { get; set; }

        public int? KonuID { get; set; }

        public virtual Konular Konular { get; set; }
    }
}
