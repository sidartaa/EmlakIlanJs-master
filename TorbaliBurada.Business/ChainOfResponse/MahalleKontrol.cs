using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Data.CodeFirst.Entity;

namespace TorbaliBurada.Business.ChainOfResponse
{
    public class MahalleKontrol : SearchEmlakBase
    {
        public override void ExecuteProcess(SerchChanRequest _search)
        {
            if (base.sonuc)
            {
                try
                {
                    EmlakKategoriler kat = _search._emlakKategoriler.GetParametreIlan(x => x.Id == _search.request.MahalleId).First();
                    var q = kat.IlanIlanlar.Skip((_search.request.page - 1) * _search.pageSize).Take(_search.pageSize).ToList();
                    if (_search.request.id == 2 && _search.request.KonutTipi != 0)
                    {
                        //var qq = kat.IlanIlanlar.ToList();
                        foreach (var item in q)
                        {
                            var tip = _search._ilanTipOzellikler.GetParametre(x => x.KonutTipiOzellikler == item.Id);
                            foreach (var tipi in tip)
                            {
                                if (tipi.EmlakIlanID == item.Id)
                                {
                                    IlanResimler img = _search._ilanResimler.GetParametre(x => x.IlanId == item.Id).FirstOrDefault();
                                    _search.ListKategori.Add(new KategoriSearch { Id = item.Id, Baslik = item.Baslik, Resim = img.Resim, Fiyat = item.Fiyat, Aciklama = item.Aciklama, MetreKare = item.MetreKare, Private = item.Private, TakasliID = item.TakasliID, UserName = item.UserName });
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (var item in q)
                        {
                            IlanResimler img = _search._ilanResimler.GetParametre(x => x.IlanId == item.Id).FirstOrDefault();
                            _search.ListKategori.Add(new KategoriSearch { Id = item.Id, Baslik = item.Baslik, Resim = img.Resim, Fiyat = item.Fiyat, Aciklama = item.Aciklama, MetreKare = item.MetreKare, Private = item.Private, TakasliID = item.TakasliID, UserName = item.UserName });
                        }
                    }

                    _search.total.totalRecord = kat.IlanIlanlar.Count();
                    _search.total.totalPage = (total.totalRecord / _search.pageSize) + ((total.totalRecord % _search.pageSize) > 0 ? 1 : 0);
                    _search.total.currentPage = _search.request.page;
                   // _search.total.NewSearchList = _search.ListKategori;

                    if (_search.request.id == 2 && _search.request.KonutTipi != 0)
                        base.sonuc = true;
                    else
                        base.sonuc = false;
                    this.ListKategori = _search.ListKategori;
                    this.total = _search.total;
                    this.request = _search.request;
                }
                catch (Exception)
                {

                    throw;
                }


            }
        }
    }
}
