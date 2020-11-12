using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.RequestMessages.Ilanlar;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.Factoty
{
  public  interface ISearch
    {
      Task<TotalPageSearchResponse> SearchQuery(IEmlakLocation _ilanLocation,IEmlakKategoriler _emlakKategoriler, TotalPageSearchResponse total, List<IlanIlanlarResponse> listIlanlar, List<EmlakLocationResponse> listAdresler, SerchRequest request);
    }
}
