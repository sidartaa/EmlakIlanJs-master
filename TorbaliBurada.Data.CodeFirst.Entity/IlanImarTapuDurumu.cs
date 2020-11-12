using System.ComponentModel.DataAnnotations.Schema;

namespace TorbaliBurada.Data.CodeFirst.Entity
{
    [Table("ekipyazi_sidart_tor.IlanImarTapuDurumu")]
    public partial class IlanImarTapuDurumu:EntityBase<int>
    {
        public int? EmlakIlanID { get; set; }
        public int? TapuDurumId { get; set; }
      
        public virtual EmlakTapuDurumu EmlakTapuDurumu { get; set; }
        public virtual IlanIlanlar IlanIlanlar { get; set; }
    }
}
