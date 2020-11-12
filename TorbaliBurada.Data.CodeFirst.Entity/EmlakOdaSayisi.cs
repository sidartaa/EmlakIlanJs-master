namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ekipyazi_sidart_tor.EmlakOdaSayisi")]
    public partial class EmlakOdaSayisi : EntityBase<int>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmlakOdaSayisi()
        {
            IlanlarEmlakGenel = new HashSet<IlanlarEmlakGenel>();
        }

        //public int Id { get; set; }

        [StringLength(50)]
        public string OdaSayisi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IlanlarEmlakGenel> IlanlarEmlakGenel { get; set; }
    }
}
