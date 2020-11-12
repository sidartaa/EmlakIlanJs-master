namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.EmlakDisOzellikler")]
    public partial class EmlakDisOzellikler : EntityBase<int>
    {
        // public int Id { get; set; }
        public EmlakDisOzellikler()
        {
            IlanDisOzellikler = new HashSet<IlanDisOzellikler>();
        }
        [StringLength(50)]
        public string DisOzellik { get; set; }
        
        public virtual ICollection<IlanDisOzellikler> IlanDisOzellikler { get; set; }
    }
}
