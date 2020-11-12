namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.EmlakImarDurumu")]
    public partial class EmlakImarDurumu : EntityBase<int>
    {
        public EmlakImarDurumu()
        {
            IlanImarDurumu = new HashSet<IlanImarDurumu>();
        }
      //  public int Id { get; set; }

        [StringLength(50)]
        public string EmlakDurumu { get; set; }
        
       public virtual ICollection<IlanImarDurumu> IlanImarDurumu { get; set; }
    }
}
