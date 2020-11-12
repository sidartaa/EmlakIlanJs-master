using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorbaliBurada.Data.CodeFirst.Entity
{
    [Table("ekipyazi_sidart_tor.IlanImarDurumu")]
    public partial class IlanImarDurumu : EntityBase<int>
    {
        public int? EmlakIlanID { get; set; }
        public int? ImarDurumId { get; set; }
        public virtual EmlakImarDurumu EmlakImarDurumu { get; set; }
        public virtual IlanIlanlar IlanIlanlar { get; set; }

    }
}
