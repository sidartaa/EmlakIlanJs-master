namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.Bulten")]
    public partial class Bulten
    {
        public int BultenID { get; set; }

        [StringLength(50)]
        public string AdSoyad { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int? Durumu { get; set; }
    }
}
