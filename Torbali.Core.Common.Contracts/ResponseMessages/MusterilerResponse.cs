using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torbali.Core.Common.Contracts.ResponseMessages
{
   public class MusterilerResponse
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string CepTelefonu { get; set; }
        public decimal? EnDusukFiyat { get; set; }
        public decimal? EnYuksekFiyat { get; set; }
        public int? Statu { get; set; }
        public int CountKategori { get; set; }
        public int CountLocation { get; set; }
        //public List<IlanResponse> KategoriIlan { get; set; }
        //public List<IlanResponse> LocationIlan { get; set; }



    }
}
