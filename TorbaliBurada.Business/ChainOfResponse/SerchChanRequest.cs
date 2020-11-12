using System.Collections.Generic;
using Torbali.Core.Common.Contracts.RequestMessages.Ilanlar;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.ChainOfResponse
{
    public class SerchChanRequest
    {
        public SerchRequest request { get; set; }
        public List<KategoriSearch> ListKategori { get; set; }
        public TotalPageSearchResponse total { get; set; }
        public List<IlanIlanlar> ilanIlanlar { get; set; }
        public IEmlakKategoriler _emlakKategoriler { get; set; }
        public IIlanResimler _ilanResimler { get; set; }
        public IIlanKonutTipiOzellikler _ilanTipOzellikler { get; set; }
        public IIlanKullanimAmaci _ilanIsyeriTipi;
        public int pageSize = 2;
    }
}
