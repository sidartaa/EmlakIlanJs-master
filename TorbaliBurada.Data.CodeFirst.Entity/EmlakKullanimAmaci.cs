namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ekipyazi_sidart_tor.EmlakKullanimAmaci")]
    public partial class EmlakKullanimAmaci :EntityBase<int>
    {
        public EmlakKullanimAmaci()
        {
            IlanKullanimAmaci = new HashSet<IlanKullanimAmaci>();
        }
     //   public int Id { get; set; }

        [StringLength(50)]
        public string KullanimAmaci { get; set; }
        public virtual ICollection<IlanKullanimAmaci> IlanKullanimAmaci { get; set; }
    }
}
