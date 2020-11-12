using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torbali.Core.Common.Contracts.RequestMessages.Kategoriler
{
  public  class EmlakKayegorilerRequest
    {
        public string KategoriAd { get; set; }

        public int? ParentID { get; set; }

        
        public string Icon { get; set; }

       
        public string Title { get; set; }

        
        public string Keyword { get; set; }

        
        public string Description { get; set; }

        
        public string Aciklama { get; set; }

       
        public string Durum { get; set; }
    }
}
