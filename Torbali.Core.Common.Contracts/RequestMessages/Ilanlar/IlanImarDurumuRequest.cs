using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torbali.Core.Common.Contracts.RequestMessages.Ilanlar
{
   public class IlanImarDurumuRequest
    {
        public int? EmlakIlanID { get; set; }
        //public int? TapuDurumId { get; set; }
         public int? ImarDurumID { get; set; }
    }
}
