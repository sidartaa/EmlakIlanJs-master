namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.EmlakYapiDurumu")]
    public partial class EmlakYapiDurumu : EntityBase<int>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmlakYapiDurumu()
        {
            IlanYapiDurumu = new HashSet<IlanYapiDurumu>();
        }

       // public int Id { get; set; }

        [StringLength(20)]
        public string YapiDurumu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IlanYapiDurumu> IlanYapiDurumu { get; set; }
    }
}
