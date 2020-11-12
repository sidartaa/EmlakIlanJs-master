namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ekipyazi_sidart_tor.IlanIcOzellikler")]
    public partial class IlanIcOzellikler:EntityBase<int>
    {
        // public int Id { get; set; }
       
        public int? EmlakIlanID { get; set; }
        public int? IcOzellikler { get; set; }

        public virtual IlanIlanlar IlanIlanlar { get; set; }
        public virtual EmlakIcOzellikler EmlakIcOzellikler { get; set; }
    }
}
