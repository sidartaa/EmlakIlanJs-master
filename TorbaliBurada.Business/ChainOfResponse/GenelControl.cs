using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Data.CodeFirst.Entity;

namespace TorbaliBurada.Business.ChainOfResponse
{
    public class GenelControl : SearchEmlakBase
    {
        public override void ExecuteProcess(SerchChanRequest _search)
        {
            if (base.sonuc)
            {
               
                var q = _search.ilanIlanlar.OrderBy(x => x.Id).Skip((_search.request.page - 1) * _search.pageSize).Take(_search.pageSize).ToList();
                _search.total.totalRecord = _search.ilanIlanlar.Count();
                _search.total.totalPage = (_search.total.totalRecord / _search.pageSize) + ((_search.total.totalRecord % _search.pageSize) > 0 ? 1 : 0);
                _search.total.currentPage = _search.request.page;
                foreach (var item in q)
                {
                    if (_ilanResimler.GetParametre(x => x.IlanId == item.Id).FirstOrDefault() != null)
                    {
                        IlanResimler img = _search._ilanResimler.GetParametre(x => x.IlanId == item.Id).FirstOrDefault();
                        img = _search._ilanResimler.GetParametre(x => x.IlanId == item.Id).FirstOrDefault();
                        _search.ListKategori.Add(new KategoriSearch { Id = item.Id, Baslik = item.Baslik, Resim = img.Resim, Fiyat = item.Fiyat, Aciklama = item.Aciklama, MetreKare = item.MetreKare, Private = item.Private, TakasliID = item.TakasliID, UserName = item.UserName });
                    }
                    else
                    {
                        _search.ListKategori.Add(new KategoriSearch { Id = item.Id, Baslik = item.Baslik, Resim = "noimages.jpg", Fiyat = item.Fiyat, Aciklama = item.Aciklama, MetreKare = item.MetreKare, Private = item.Private, TakasliID = item.TakasliID, UserName = item.UserName });
                    }
                   
                }
              //  _search.total.NewSearchList = _search.ListKategori;
                base.sonuc = true;
                base._ilanIsyeriTipi = _search._ilanIsyeriTipi;
                //_search.total.totalRecord = _ kat.IlanIlanlar.Count();                
                base.ListKategori = _search.ListKategori;
                base.total = _search.total;
                base.request = _search.request;
                base._emlakKategoriler = _search._emlakKategoriler;
                base._ilanResimler = _search._ilanResimler;
                base._ilanTipOzellikler = _search._ilanTipOzellikler;
                base.pageSize = _search.pageSize;
                base.ilanIlanlar = _search.ilanIlanlar;
            }
        }
    }
}
