using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorbaliBurada.Data.CodeFirst.Entity
{
    [Table("ekipyazi_sidart_tor.IlanResimler")]
    public partial class IlanResimler:EntityBase<int>
    {
       
        public int? IlanId { get; set; }
        public string Resim { get; set; }
        public virtual IlanIlanlar IlanIlanlar { get; set; }
    }
}
//Add-Migration Initial
 //CreateTable(
 //          "ekipyazi_sidart_tor.IlanResimler",
 //          c => new
 //          {
 //              Id = c.Int(nullable: false, identity: true),
 //              IlanId = c.Int(nullable: false),
 //              Resim=c.String(nullable:true,maxLength:150)

 //          })
 //          .PrimaryKey(t => t.Id)
 //          ;