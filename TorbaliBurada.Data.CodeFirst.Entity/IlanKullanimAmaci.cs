namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.IlanKullanimAmaci")]
    public partial class IlanKullanimAmaci : EntityBase<int>
    {
      //  public int IlanKullanimAmaciID { get; set; }

        public int? EmlakIlanID { get; set; }
        
        public int? KullanimAmaci { get; set; }

        public virtual IlanIlanlar IlanIlanlar { get; set; }
        public virtual EmlakKullanimAmaci EmlakKullanimAmaci { get; set; }
    }
}
