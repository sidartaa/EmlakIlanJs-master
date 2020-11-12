namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ekipyazi_sidart_tor.EmlakIcOzellikler")]
    public partial class EmlakIcOzellikler : EntityBase<int>
    {
        //  public int Id { get; set; }
        public EmlakIcOzellikler()
        {
            IlanIcOzellikler = new HashSet<IlanIcOzellikler>();
        }
        [StringLength(50)]
        public string IcOzellik { get; set; }
        public virtual ICollection<IlanIcOzellikler> IlanIcOzellikler { get; set; }
    }
}
