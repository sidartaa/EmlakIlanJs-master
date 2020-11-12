using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torbali.Core.Common.Contracts.RequestMessages.Musteriler
{
   public class MusterilerListInsertRequest 
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string CepTelefonu { get; set; }
        public decimal? EnDusukFiyat { get; set; }
        public decimal? EnYuksekFiyat { get; set; }
        public int? Statu { get; set; }
        public string Kategori { get; set; }       
        public string Location { get; set; }
        public string Tur { get; set; }
        public string Semt { get; set; }

    }
}
