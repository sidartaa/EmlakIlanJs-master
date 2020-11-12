using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torbali.Core.Common.Contracts.RequestMessages.Ilanlar
{
  public class IlanKonutTipiOzelliklerRequest
    {
        public int? EmlakIlanID { get; set; }       
        public int KonutTipiOzellikler { get; set; }
    }
}
