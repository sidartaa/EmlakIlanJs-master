using System.Collections.Generic;
using System.Linq;
using TorbaliBurada.Data.CodeFirst.Entity;

namespace Torbali.Core.Common.Contracts.ResponseMessages
{
    public class TotalPageSearchResponse
    {
        public List<IlanIlanlarResponse> Ilanlar { get; set; }
       // public List<EmlakLocationResponse> Adresler { get; set; }
        public int totalPage { get; set; }
        public int totalRecord { get; set; }
        public int pageSize { get; set; }
        public int currentPage { get; set; }
       public bool isLocation { get; set; }
        // public List<KategoriSearch> NewSearchList { get; set; }

    }
    public class KategoriSearch
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
       
        public string Aciklama { get; set; }

        public decimal? Fiyat { get; set; }
      
        public string MetreKare { get; set; }

        public int? TakasliID { get; set; }

        public string UserName { get; set; }
      
        public string Private { get; set; }
        public string Resim { get; set; }
    }

    
}
