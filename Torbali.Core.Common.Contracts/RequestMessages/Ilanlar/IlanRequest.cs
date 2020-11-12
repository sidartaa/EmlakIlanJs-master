using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorbaliBurada.Data.CodeFirst.Entity;

namespace Torbali.Core.Common.Contracts.RequestMessages.Ilanlar
{
  public  class IlanRequest
    {
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public decimal? Fiyat { get; set; }
        public string MetreKare { get; set; }
        public int? TakasliID { get; set; }
        public string Private { get; set; }
        public string UserName { get; set; }
        public string CepTelefonu { get; set; }
        public string TakasTuru { get; set; }
        public string Sahibi { get; set; }
        public string Ada { get; set; }
        public string Pafta { get; set; }
        public string Parsel { get; set; }
        public string IletisimTelefonu { get; set; }





    }
}
