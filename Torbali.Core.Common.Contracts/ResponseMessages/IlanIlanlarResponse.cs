using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torbali.Core.Common.Contracts.ResponseMessages
{
  public  class IlanIlanlarResponse
    {
        public int Id { get; set; }
        //public string Ilce { get; set; }
        //public string Semt { get; set; }
        //public string Mahalle { get; set; }
        public string IlanKimden { get; set; }
        //İlanlar İlan
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public decimal? Fiyat { get; set; }
        public string MetreKare { get; set; }
        public int? Takasli { get; set; }
        public string TakasTuru { get; set; }
        public string Private { get; set; }
        public string UserName { get; set; }
        public string IletisimTelefonu { get; set; }
        public string Resim { get; set; }
        public string IlanSahibi { get; set; }
        public string IlanSahibiCepTelefonu { get; set; }
        public string Ada { get; set; }
        public string Pafta { get; set; }
        public string Parsel { get; set; }
        public List<EmlakLocationResponse> Location { get; set; }
        


    }
}
