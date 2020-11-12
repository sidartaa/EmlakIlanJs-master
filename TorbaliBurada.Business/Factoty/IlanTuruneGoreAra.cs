using AutoMapper;
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
    public class IlanTuruneGoreAra : ISearch
    {
        public Task<TotalPageSearchResponse> SearchQuery(IEmlakLocation _ilanLocation, IEmlakKategoriler _emlakKategoriler, TotalPageSearchResponse total, List<IlanIlanlarResponse> listIlanlar, List<EmlakLocationResponse> listAdresler, SerchRequest request)
        {
            return Task.Run(() => this.TuruneGoreAra(_ilanLocation, _emlakKategoriler, total, listIlanlar, listAdresler, request));
            //return Task.FromResult<TotalPageSearchResponse>(this.TuruneGoreAra(_emlakKategoriler, total, listIlanlar, listAdresler, request));
        }

        private async Task<TotalPageSearchResponse> TuruneGoreAra(IEmlakLocation _ilanLocation, IEmlakKategoriler _emlakKategoriler, TotalPageSearchResponse total, List<IlanIlanlarResponse> listIlanlar, List<EmlakLocationResponse> listAdresler, SerchRequest request)
        {
            int pageSize = 2;

            var tipi = await _emlakKategoriler.GetAsync(request.id);
            if (total.totalRecord <= 0)
                total.totalRecord = tipi.IlanIlanlar.Count();
            if (total.totalPage <= 0)
                total.totalPage = (total.totalRecord / pageSize) + ((total.totalRecord % pageSize) > 0 ? 1 : 0);
            total.currentPage = request.page;
            int skip = (request.page - 1) * pageSize;
            var kat = tipi.IlanIlanlar.Skip(skip).Take(pageSize).Where(x => x.Private == "Genel");

            foreach (var item in kat)
            {

                listAdresler.Clear();
                foreach (var adres in item.EmlakLocation)
                {

                    if (adres.Id > 0)
                    {
                        listAdresler.Add(new EmlakLocationResponse
                        {
                            LocationName = adres.LocationName
                        });
                    }
                    else
                    {

                        total.isLocation = false;
                    }

                }
                string resim = (item.IlanResimler.Count() > 0 ? item.IlanResimler.First().Resim : "noimages.jpg");
                string ilanKimden = item.IlanKimden.First().EmlakKimden.Kimden;
                listIlanlar.Add(new IlanIlanlarResponse
                {
                    Id = item.Id,
                    Baslik = item.Baslik,
                    Aciklama = item.Aciklama,
                    Fiyat = item.Fiyat,
                    MetreKare = item.MetreKare,
                    Takasli = item.TakasliID,
                    TakasTuru = item.TakasTuru,
                    Resim = resim,
                    IletisimTelefonu = item.IletisimTelefonu,
                    IlanKimden = ilanKimden,
                    Location = listAdresler
                });
            }
            // total.Adresler = listAdresler;
            //  total.NewSearchList = listKategori;
            total.Ilanlar = listIlanlar;
            return total;
        }
    }
}
