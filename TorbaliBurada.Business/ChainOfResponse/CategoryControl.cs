using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorbaliBurada.Data.CodeFirst.Entity;

namespace TorbaliBurada.Business.ChainOfResponse
{
    public class CategoryControl : SearchEmlakBase
    {
        public override void ExecuteProcess(SerchChanRequest _search)
        {
            //1-CategoriControl
            //2-SellControl
            //3-SemtControl
            //4-MahalleControl
            //5-GetKategoriFirst
            //6-KonutTipiControl
            //7-IsyeriTipiControl
            //8-ArsaTipiControl
            //9-GenelControl

            _search.request.id = Convert.ToInt32(_search.request.id);
            // _search.request.SatilikId = Convert.ToInt32(_search.request.SatilikId);
            // _search.request.SemtId = Convert.ToInt32(_search.request.SemtId);
            //  _search.request.MahalleId = Convert.ToInt32(_search.request.MahalleId);
            // _search.request.KonutTipi = Convert.ToInt32(_search.request.KonutTipi);
            if (_search.request.id != 0)
                base.sonuc = true;
            else
            {
                _search.ilanIlanlar.Clear();
                EmlakKategoriler kat = _search._emlakKategoriler.GetParametreIlan(x => x.Id == _search.request.id).First();
                _search.ilanIlanlar = kat.IlanIlanlar.Where(x => x.Private == "Genel").ToList();
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
