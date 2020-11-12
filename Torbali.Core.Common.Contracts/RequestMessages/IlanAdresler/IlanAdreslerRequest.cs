using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torbali.Core.Common.Contracts.RequestMessages.IlanAdresler
{
   public class IlanAdreslerRequest
    {
        public int  EmlakIlanID { get; set; }
        public int LocationID { get; set; }
        public string Adres { get; set; }
    }
}
