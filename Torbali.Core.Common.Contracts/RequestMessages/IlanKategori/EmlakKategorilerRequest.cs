using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torbali.Core.Common.Contracts.RequestMessages.IlanKategori
{
    public class EmlakKategorilerRequest
    {
        public int Id { get; set; }

        public string KategoriAd { get; set; }

        public int? ParentID { get; set; }
    }
}
