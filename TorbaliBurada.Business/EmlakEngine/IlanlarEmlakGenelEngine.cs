using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.RequestMessages.IlanEmlakGenel;
using Torbali.Core.Common.Contracts.RequestMessages.Ilanlar;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts.IEmlakEngine;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class IlanlarEmlakGenelEngine : BusinessEngineBase, IIlanlarEmlakGenelEngine
    {
        private readonly IIlanIlanlar _ilanIlanlar;
        private readonly IIlanlarEmlakGenel _genel;
        private readonly IIlanlarIcOzellikler _icOzellikler;
        private readonly IIlanlarDisOzellikler _disOzellikler;
        private readonly IIlanResimler _ilanResimler;
        private readonly IIlanKullanimAmaci _ilanKullanimAmaci;
        private readonly IIlanImarDurumu _ilanImarDurumu;
        private readonly IIlanImarTapuDurumu _ilanImarTapuDurumu;
        private readonly IEmlakKategoriler _emlakKategoriler;
        
        

        public IlanlarEmlakGenelEngine(IIlanIlanlar ilanIlanlar, IIlanlarEmlakGenel genel, IIlanlarIcOzellikler icOzellikler, IIlanlarDisOzellikler disOzellikler, IIlanResimler ilanResimler, IIlanKullanimAmaci ilanKullanimAmaci, IIlanImarDurumu ilanImarDurumu, IIlanImarTapuDurumu ilanImarTapuDurum,IEmlakKategoriler emlakKategoriler)
        {
            _ilanIlanlar = ilanIlanlar;
            _genel = genel;
            _icOzellikler = icOzellikler;
            _disOzellikler = disOzellikler;
            _ilanResimler = ilanResimler;
            _ilanKullanimAmaci = ilanKullanimAmaci;
            _ilanImarDurumu = ilanImarDurumu;
            _ilanImarTapuDurumu = ilanImarTapuDurum;
            _emlakKategoriler = emlakKategoriler;
        }
        public Task<IlanEmlakGenelResponse> CreateAsync(IlanlarEmlakGenelRequest request)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IlanEmlakGenelResponse> GetAsync(IlanEmlakGenelRequest id)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {

                var i = Convert.ToInt32(id.id);
                IlanEmlakGenelResponse get = new IlanEmlakGenelResponse();
                IlanIlanlarResponse ilan = new IlanIlanlarResponse();
                List<IlanResimlerResponse> resimler = new List<IlanResimlerResponse>();
                List<EmlakKategoilerResponse> kategoriler = new List<EmlakKategoilerResponse>();
                List<IlanIcOzelliklerResponse> icOzellikler = new List<IlanIcOzelliklerResponse>();
                List<IlanDisOzelliklerResponse> disOzellikler = new List<IlanDisOzelliklerResponse>();
                List<EmlakLocationResponse> listAdresler = new List<EmlakLocationResponse>();
                

                var getIlan = await _ilanIlanlar.GetAsync(id.id);
                //var ozellikler = await _genel.GetAsync(getIlan.IlanlarEmlakGenel.First().Id);
                //var kullanimAmaci = await _ilanKullanimAmaci.GetAsync(getIlan.IlanKullanimAmaci.First().Id);
                //var ilanImarDurumu =await _ilanImarDurumu.GetAsync(getIlan.IlanImarDurumu.First().Id);
                //var ilanImarTapuDurumu = await _ilanImarTapuDurumu.GetAsync(getIlan.IlanImarTapuDurumu.First().Id);

                listAdresler.Clear();
                foreach (var adres in getIlan.EmlakLocation)
                {
                    listAdresler.Add(new EmlakLocationResponse
                    {
                        LocationName = adres.LocationName
                    });
                }

                //İlan Ekle
                ilan.Id = getIlan.Id;
                ilan.Baslik = getIlan.Baslik;
                ilan.Fiyat = Convert.ToDecimal(getIlan.Fiyat);
                ilan.MetreKare = getIlan.MetreKare;
                ilan.Takasli = getIlan.TakasliID;
                ilan.Aciklama = getIlan.Aciklama;
                ilan.Private = getIlan.Private;
                ilan.UserName = getIlan.UserName;
                ilan.IlanKimden = getIlan.IlanKimden.First().EmlakKimden.Kimden;
                ilan.IletisimTelefonu = getIlan.IletisimTelefonu;
                ilan.Location = listAdresler;
               
                ilan.TakasTuru = getIlan.TakasTuru;                
                get.ilan = ilan;

                //İlan Özellikleri
                //get.Id = getIlan.IlanlarEmlakGenel.First().Id;
               
                foreach (var item in getIlan.IlanlarEmlakGenel)
                {
                    
                    get.OdaSayisiID = (item.OdaSayisiID != null ? item.EmlakOdaSayisi.OdaSayisi.ToString() : "");
                    get.BulunduguKatID = (item.BulunduguKatID != null ? item.EmlakBulunduguKat.BulunduguKat.ToString() : ""); 
                    get.IsitmaID = (item.IsitmaID!=null ? item.EmlakIsitmaTuru.Isitma.ToString():"");
                }

                //İlan Kullanım Amacı

                foreach (var amac in getIlan.IlanKullanimAmaci)
                {
                    get.EmlakKullanimAmaci = amac.EmlakKullanimAmaci.KullanimAmaci.ToString();
                }

                //İlan Imar DUrumu
                foreach (var durum in getIlan.IlanImarDurumu)
                {
                    get.EmlakDurumu = durum.EmlakImarDurumu.EmlakDurumu.ToString();
                }

                //ilanImarTapuDurumu
                foreach (var tapu in getIlan.IlanImarTapuDurumu)
                {
                    get.TapuDurumu = tapu.EmlakTapuDurumu.TapuDurumu.ToString();
                }

                //İlan Resimleri
                foreach (var item in getIlan.IlanResimler.ToList())
                {
                    resimler.Add(new IlanResimlerResponse { Id=item.Id, Resim=item.Resim });
                }
                get.ilanResimler = resimler;

                //İlan kategorileri
                foreach (var kategori in getIlan.EmlakKategoriler.ToList())
                {
                    kategoriler.Add(new EmlakKategoilerResponse { Id=kategori.Id, KategoriAd=kategori.KategoriAd });
                }
                get.ilanKategoriler = kategoriler;

                //İlan Ic Ozellikler
                foreach (var ic in getIlan.IlanIcOzellikler.ToList())
                {
                    icOzellikler.Add(new IlanIcOzelliklerResponse { IcOzellikler=ic.EmlakIcOzellikler.IcOzellik });
                }
                get.ilanIcOzellikler = icOzellikler;

                //Ilan Dış özellikler
                foreach (var dis in getIlan.IlanDisOzellikler.ToList())
                {
                    disOzellikler.Add(new IlanDisOzelliklerResponse { DisOzellikler= dis.EmlakDisOzellikler.DisOzellik });
                }
                get.ilanDisOzellikler = disOzellikler;               
               

                return Mapper.Map<IlanEmlakGenelResponse>(get);
            });
        }

        public Task<IlanEmlakGenelResponse> UpdateAsync(IlanlarEmlakGenelRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
