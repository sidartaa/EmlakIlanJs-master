using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torbali.Core.Common.Contracts.RequestMessages.Ilanlar
{
   public class IlanIcOzelliklerRequest
    {
       public  int? EmlakIlanID { get; set; }
       public string IcOzellikler { get; set; }
    }
}
