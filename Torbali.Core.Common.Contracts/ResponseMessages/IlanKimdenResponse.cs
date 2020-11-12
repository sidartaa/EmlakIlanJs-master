using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torbali.Core.Common.Contracts.ResponseMessages
{
   public class IlanKimdenResponse
    {
        public int Id { get; set; }
        public int EmlakIlanID { get; set; }
        public int KimdenID { get; set; }
    }
}
