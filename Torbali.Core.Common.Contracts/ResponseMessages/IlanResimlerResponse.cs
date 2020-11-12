using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torbali.Core.Common.Contracts.ResponseMessages
{
   public class IlanResimlerResponse
    {
        public int Id { get; set; }
        public int? IlanId { get; set; }
        public string Resim { get; set; }
       
    }
}
