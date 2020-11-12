namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.Konular")]
    public partial class Konular : EntityBase<int>
    {
       
        public Konular()
        {
            Dosyalar = new HashSet<Dosyalar>();
            Etiketler = new HashSet<Etiketler>();
            Resimler = new HashSet<Resimler>();
            Kategoriler = new HashSet<Kategoriler>();
        }

       // public int Id { get; set; }

        [StringLength(250)]
        public string Baslik { get; set; }

        [Column(TypeName = "text")]
        public string KisaIcerik { get; set; }

        [Column(TypeName = "text")]
        public string UzunIcerik { get; set; }

        [StringLength(150)]
        public string Resim { get; set; }

        public DateTime? Tarih { get; set; }

        [StringLength(10)]
        public string Statu { get; set; }

        public int? OkunmaSayisi { get; set; }

        public int? YorumSayisi { get; set; }

        [StringLength(150)]
        public string Dosya { get; set; }

        public int? Manset { get; set; }

        [StringLength(150)]
        public string Seo { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

       
        public virtual ICollection<Dosyalar> Dosyalar { get; set; }

       
        public virtual ICollection<Etiketler> Etiketler { get; set; }

      
        public virtual ICollection<Resimler> Resimler { get; set; }

        
        public virtual ICollection<Kategoriler> Kategoriler { get; set; }
    }
}
