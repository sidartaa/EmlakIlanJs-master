using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torbali.Core.Common.Contracts.RequestMessages.Ilanlar
{
  public class IlanDisOzelliklerRequest
    {
        public int? EmlakIlanID { get; set; }
        public string DisOzellikler { get; set; }
    }
}
