namespace TorbaliBurada.Data.CodeFirst.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ekipyazi_sidart_tor.IlanYapiDurumu")]
    public partial class IlanYapiDurumu : EntityBase<int>
    {
      //  public int Id { get; set; }

        public int? EmlakIlanID { get; set; }

        public int? YapiDurumuID { get; set; }

        public virtual EmlakYapiDurumu EmlakYapiDurumu { get; set; }

        public virtual IlanIlanlar IlanIlanlar { get; set; }
    }
}
