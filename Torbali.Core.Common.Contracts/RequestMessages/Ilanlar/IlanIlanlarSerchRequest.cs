using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torbali.Core.Common.Contracts.RequestMessages.Ilanlar
{
 public class SerchRequest
    {
        public int skip { get; set; }
        public int take { get; set; }
        public string userName { get; set; }
        public int page { get; set; }
        public int TotalPage  { get; set; }
        public int id { get; set; }
        public int SatilikId { get; set; }
        public int SemtId { get; set; }
        public int MahalleId { get; set; }
        public int KonutTipi { get; set; }
        public int IsyeriTipi { get; set; }
        public int ArsaTipi { get; set; }
        public int IlanTuru { get; set; }
    }
}
