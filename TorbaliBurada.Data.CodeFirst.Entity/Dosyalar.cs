namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.Dosyalar")]
    public partial class Dosyalar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DosyaID { get; set; }

        public int? KonuID { get; set; }

        [StringLength(150)]
        public string DosyaAd { get; set; }

        public virtual Konular Konular { get; set; }
    }
}
