namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ekipyazi_sidart_tor.IlanlarEmlakGenel")]
    public partial class IlanlarEmlakGenel : EntityBase<int>
    {
      
       // public int IlanEmlakGenelID { get; set; }

        public int? EmlakIlanID { get; set; }

        public int? OdaSayisiID { get; set; }

        public int? BinaYasiID { get; set; }

        public int? BulunduguKatID { get; set; }

        public int? KatSayisiID { get; set; }

        public int? IsitmaID { get; set; }

        public int? BanyoSayisiID { get; set; }

        public int? KullanimDurumuID { get; set; }

        public int? SiteIcerisindeID { get; set; }

        public bool? Aidat { get; set; }

        public virtual EmlakBanyoSayisi EmlakBanyoSayisi { get; set; }

        public virtual EmlakBinaYasi EmlakBinaYasi { get; set; }

        public virtual EmlakBulunduguKat EmlakBulunduguKat { get; set; }

        public virtual EmlakIsitmaTuru EmlakIsitmaTuru { get; set; }

        public virtual EmlakKatSayisi EmlakKatSayisi { get; set; }

        public virtual EmlakKullanimDurumu EmlakKullanimDurumu { get; set; }

        public virtual EmlakOdaSayisi EmlakOdaSayisi { get; set; }

        public virtual EmlakSiteIcerisinde EmlakSiteIcerisinde { get; set; }

        public virtual IlanIlanlar IlanIlanlar { get; set; }
    }
}
