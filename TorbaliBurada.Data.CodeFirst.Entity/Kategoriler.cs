namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.Kategoriler")]
    public partial class Kategoriler : EntityBase<int>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kategoriler()
        {
            Konular = new HashSet<Konular>();
        }

      //  public int Id { get; set; }

        [StringLength(50)]
        public string KategoriAd { get; set; }

        [Column(TypeName = "text")]
        public string Aciklama { get; set; }

        [StringLength(150)]
        public string Seo { get; set; }

        [StringLength(250)]
        public string Keywords { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(10)]
        public string Statu { get; set; }

        public int? ParentID { get; set; }

        [StringLength(250)]
        public string Url { get; set; }

        [StringLength(50)]
        public string Icon { get; set; }

       
        public virtual ICollection<Konular> Konular { get; set; }
    }
}
