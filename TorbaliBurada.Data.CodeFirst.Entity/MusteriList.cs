using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorbaliBurada.Data.CodeFirst.Entity
{
    [Table("ekipyazi_sidart_tor.MusteriList")]
    public partial class MusteriList : EntityBase<int>
    {
        public MusteriList()
        {
            EmlakKategoriler = new HashSet<EmlakKategoriler>();
            EmlakLocation = new HashSet<EmlakLocation>();
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string CepTelefonu { get; set; }
        public decimal? EnDusukFiyat { get; set; }
        public decimal? EnYuksekFiyat { get; set; }
        public int? Statu { get; set; }
        public virtual ICollection<EmlakKategoriler> EmlakKategoriler { get; set; }
        public virtual ICollection<EmlakLocation> EmlakLocation { get; set; }
        public virtual MusteriListStatu MusteriListStatu { get; set; }
    }
}
