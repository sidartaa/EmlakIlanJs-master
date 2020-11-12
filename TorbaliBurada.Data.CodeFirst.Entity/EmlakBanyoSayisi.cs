namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.EmlakBanyoSayisi")]
    public partial class EmlakBanyoSayisi : EntityBase<int>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmlakBanyoSayisi()
        {
            IlanlarEmlakGenel = new HashSet<IlanlarEmlakGenel>();
        }

      //  public int Id { get; set; }

        [StringLength(10)]
        public string BanyoSayisi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IlanlarEmlakGenel> IlanlarEmlakGenel { get; set; }
    }
}
