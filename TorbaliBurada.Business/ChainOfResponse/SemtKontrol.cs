using System;
using System.Linq;
using TorbaliBurada.Data.CodeFirst.Entity;

namespace TorbaliBurada.Business.ChainOfResponse
{
    public class SemtKontrol : SearchEmlakBase
    {
        public override void ExecuteProcess(SerchChanRequest _search)
        {
            if (base.sonuc)//bir önceki adımdan geçiyorsa
            {
                try
                {
                    _search.request.SemtId = Convert.ToInt32(_search.request.SemtId);
                    if (_search.request.SemtId != 0 && _search.request.KonutTipi !=0 && _search.request.id==2)
                    {
                        EmlakKategoriler kat = _search._emlakKategoriler.GetParametreIlan(x => x.Id == _search.request.SemtId).First();
                        _search.ilanIlanlar = kat.IlanIlanlar.ToList();
                        base.sonuc = true;                       
                    }
                    else
                    {
                        EmlakKategoriler kat = _search._emlakKategoriler.GetParametreIlan(x => x.Id == _search.request.SemtId).First();
                        _search.ilanIlanlar = kat.IlanIlanlar.Skip((_search.request.page - 1) * _search.pageSize).Take(_search.pageSize).ToList();
                        base.sonuc = false;
                        _search.total.totalRecord = kat.IlanIlanlar.Count();
                    }
                    base.ListKategori = _search.ListKategori;
                    base.total= _search.total;
                    base.request = _search.request;
                    base._emlakKategoriler = _search._emlakKategoriler;
                    base._ilanResimler =_search._ilanResimler;
                    base._ilanTipOzellikler =_search._ilanTipOzellikler;
                    base.pageSize = _search.pageSize;
                    base.ilanIlanlar = _search.ilanIlanlar;
                    


                }
                catch (Exception)
                {
                    base.sonuc = false;
                    throw;
                }
            }
        }
    }
}
