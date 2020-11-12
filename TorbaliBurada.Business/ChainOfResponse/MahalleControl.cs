using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorbaliBurada.Data.CodeFirst.Entity;

namespace TorbaliBurada.Business.ChainOfResponse
{
    public class MahalleControl : SearchEmlakBase
    {
        public override void ExecuteProcess(SerchChanRequest _search)
        {
            if (base.sonuc)//bir önceki adımdan geçiyorsa
            {
                // _search.request.id = Convert.ToInt32(_search.request.id);
                //_search.request.SatilikId = Convert.ToInt32(_search.request.SatilikId);
                // _search.request.SemtId = Convert.ToInt32(_search.request.SemtId);
                 _search.request.MahalleId = Convert.ToInt32(_search.request.MahalleId);
                // _search.request.KonutTipi = Convert.ToInt32(_search.request.KonutTipi);
                if (_search.request.MahalleId != 0)
                {
                    _search.ilanIlanlar.Clear();
                    EmlakKategoriler kat = _search._emlakKategoriler.GetParametreIlan(x => x.Id == _search.request.MahalleId).First();
                    _search.ilanIlanlar = kat.IlanIlanlar.ToList();
                    base.sonuc = false;                    
                }
                else
                {
                    _search.ilanIlanlar.Clear();
                    EmlakKategoriler kat = _search._emlakKategoriler.GetParametreIlan(x => x.Id == _search.request.SemtId).First();
                    _search.ilanIlanlar = kat.IlanIlanlar.ToList();
                    base.sonuc = false;
                }
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
