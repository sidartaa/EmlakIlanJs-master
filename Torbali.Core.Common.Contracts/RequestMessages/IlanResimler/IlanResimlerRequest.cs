using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torbali.Core.Common.Contracts.RequestMessages.IlanResimler
{
    public class IlanResimlerRequest
    {
        public int IlanId { get; set; }
        public string Resim { get; set; }
        public List<string> Resimler { get; set; }
    }
}
