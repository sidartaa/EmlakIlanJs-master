using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torbali.Core.Common.Contracts.ResponseMessages
{
   public class MusterilerListResponse
    {
        public List<MusterilerResponse> Musteriler { get; set; }
        //public List<IlanResponse> KategoriIlan { get; set; }
        //public List<IlanResponse> LocationIlan { get; set; }
        public int totalPage { get; set; }
        public int totalRecord { get; set; }
        public int pageSize { get; set; }
        public int currentPage { get; set; }
    }
}
