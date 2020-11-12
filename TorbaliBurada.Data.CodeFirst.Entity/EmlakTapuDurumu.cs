namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ekipyazi_sidart_tor.EmlakTapuDurumu")]
    public partial class EmlakTapuDurumu : EntityBase<int>
    {
        public EmlakTapuDurumu()
        {
            IlanImarTapuDurumu = new HashSet<IlanImarTapuDurumu>(); 

        }
      //  public int Id { get; set; }

        [StringLength(50)]
        public string TapuDurumu { get; set; }
        public virtual ICollection<IlanImarTapuDurumu> IlanImarTapuDurumu { get; set; }
    }
}
