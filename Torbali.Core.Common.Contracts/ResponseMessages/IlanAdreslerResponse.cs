using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torbali.Core.Common.Contracts.ResponseMessages
{
   public class IlanAdreslerResponse
    {
        public int Id { get; set; }
        public int EmlakIlanID { get; set; }
        public int LacationID { get; set; }
        public string Adres { get; set; }
    }
}
