using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torbali.Core.Common.Contracts.ResponseMessages
{
   public class IlanResponse
    {
        
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public decimal? Fiyat { get; set; }       
        public string MetreKare { get; set; }
        public int? TakasliID { get; set; }
        public string UserName { get; set; }
        public string Private { get; set; }
        public int Id { get; set; }
        
        
    }
}
