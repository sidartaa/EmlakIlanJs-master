namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.EmlakBulunduguKat")]
    public partial class EmlakBulunduguKat : EntityBase<int>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmlakBulunduguKat()
        {
            IlanlarEmlakGenel = new HashSet<IlanlarEmlakGenel>();
        }

      //  public int Id { get; set; }

        [StringLength(50)]
        public string BulunduguKat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IlanlarEmlakGenel> IlanlarEmlakGenel { get; set; }
    }
}
