using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorbaliBurada.Data.CodeFirst.Entity
{
    [Table("ekipyazi_sidart_tor.MusteriListStatu")]
    public partial class MusteriListStatu : EntityBase<int>
    {
        public MusteriListStatu()
        {
            MusteriList = new HashSet<MusteriList>();

        }
        public string StatuDurumu { get; set; }
        public virtual ICollection<MusteriList> MusteriList { get; set; }
    }

}
