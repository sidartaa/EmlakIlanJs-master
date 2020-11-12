namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.IlanIlanlar")]
    public partial class IlanIlanlar : EntityBase<int>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IlanIlanlar()
        {
           // IlanAdresler = new HashSet<IlanAdresler>();
            IlanCepheOzellikler = new HashSet<IlanCepheOzellikler>();
            IlanDisOzellikler = new HashSet<IlanDisOzellikler>();
            IlanIcOzellikler = new HashSet<IlanIcOzellikler>();
            IlanKimden = new HashSet<IlanKimden>();
            IlanKonutTipiOzellikler = new HashSet<IlanKonutTipiOzellikler>();
            IlanKullanimAmaci = new HashSet<IlanKullanimAmaci>();
            IlanlarEmlakGenel = new HashSet<IlanlarEmlakGenel>();
            IlanManzaraOzellikler = new HashSet<IlanManzaraOzellikler>();
            IlanMuhitOzellikler = new HashSet<IlanMuhitOzellikler>();
            IlanUlasimOzellikler = new HashSet<IlanUlasimOzellikler>();
            IlanYapiDurumu = new HashSet<IlanYapiDurumu>();
            EmlakKategoriler = new HashSet<EmlakKategoriler>();
            IlanResimler = new HashSet<IlanResimler>();
            IlanImarTapuDurumu = new HashSet<IlanImarTapuDurumu>();
            IlanImarDurumu = new HashSet<IlanImarDurumu>();
            EmlakLocation = new HashSet<EmlakLocation>();
        }

      //  public int Id { get; set; }
        [StringLength(50)]
        public string Sahibi { get; set; }

        [StringLength(11)]
        public string CepTelefonu { get; set; }
        [StringLength(350)]
        public string Baslik { get; set; }

        [Column(TypeName = "text")]
        public string Aciklama { get; set; }

        public decimal? Fiyat { get; set; }

        [StringLength(10)]
        public string MetreKare { get; set; }

        public int? TakasliID { get; set; }

     //   public int? SaticiTuruID { get; set; }

        [StringLength(50)]
        public string TakasTuru { get; set; }
        [StringLength(10)]
        public string Ada { get; set; }

        [StringLength(10)]
        public string Pafta { get; set; }

        [StringLength(10)]
        public string Parsel { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(10)]
        public string Private { get; set; }
        public string IletisimTelefonu { get; set; }
        public virtual EmlakTakasli EmlakTakasli { get; set; }
       

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<IlanAdresler> IlanAdresler { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IlanCepheOzellikler> IlanCepheOzellikler { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IlanDisOzellikler> IlanDisOzellikler { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IlanIcOzellikler> IlanIcOzellikler { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IlanKimden> IlanKimden { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IlanKonutTipiOzellikler> IlanKonutTipiOzellikler { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IlanKullanimAmaci> IlanKullanimAmaci { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IlanlarEmlakGenel> IlanlarEmlakGenel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IlanManzaraOzellikler> IlanManzaraOzellikler { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IlanMuhitOzellikler> IlanMuhitOzellikler { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IlanUlasimOzellikler> IlanUlasimOzellikler { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IlanYapiDurumu> IlanYapiDurumu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmlakKategoriler> EmlakKategoriler { get; set; }
        public virtual ICollection<EmlakLocation> EmlakLocation { get; set; }
        public virtual ICollection<IlanResimler> IlanResimler { get; set; }
        public virtual ICollection<IlanImarTapuDurumu> IlanImarTapuDurumu { get; set; }
        public virtual ICollection<IlanImarDurumu> IlanImarDurumu { get; set; }
    }
}
