namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ekipyazi_sidart_tor.IlanKonutTipiOzellikler")]
    public partial class IlanKonutTipiOzellikler : EntityBase<int>
    {
        //public int IlanKonutTipiOzelliklerID { get; set; }

        public int? EmlakIlanID { get; set; }

       
        public int? KonutTipiOzellikler { get; set; }

        public virtual IlanIlanlar IlanIlanlar { get; set; }
        public virtual EmlakKonutTipi EmlakKonutTipi { get; set; }
    }
}
