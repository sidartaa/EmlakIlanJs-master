using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.RequestMessages.Ilanlar;

namespace TorbaliBurada.Business.Factoty
{
  public  class AramaFabrikasi
    {
        public ISearch AramaNesnesiOlustur(SerchRequest request)
        {
            if (request.id > 0 && request.SatilikId == 0 && request.SemtId == 0)
                return new IlanTuruneGoreAra();
            if (request.id > 0 && request.SatilikId > 0 && request.SemtId==0)
                return new IlanTipineGoreAra();
            if(request.id > 0 && request.SatilikId > 0 && request.SemtId >0)
                return new IlanSemtineGoreAra();
            return new IlanTuruneGoreAra();
        }
    }
}
