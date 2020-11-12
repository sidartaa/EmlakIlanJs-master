namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.IlanKimden")]
    public partial class IlanKimden:EntityBase<int>
    {
     //   public int IlanKimdenID { get; set; }

        public int? EmlakIlanID { get; set; }

        public int? KimdemID { get; set; }

        public virtual EmlakKimden EmlakKimden { get; set; }

        public virtual IlanIlanlar IlanIlanlar { get; set; }
    }
}
