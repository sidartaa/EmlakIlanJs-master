using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.RequestMessages.IlanKimden;
using Torbali.Core.Common.Contracts.RequestMessages.Ilanlar;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Business.Factoty;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class IlanlarIlanEngine : BusinessEngineBase, IIlanlarIlanEngine
    {
       
        private readonly IIlanIlanlar _ilanIlanlar;
        private readonly IIlanlarEmlakGenel _genel;
        private readonly IIlanlarIcOzellikler _icOzellikler;
        private readonly IIlanlarDisOzellikler _disOzellikler;
        private readonly IEmlakKategoriler _emlakKategoriler;
        private readonly IIlanKonutTipiOzellikler _emlakTip;
        private readonly IIlanKullanimAmaci _ilanKullanimAmaci;
        private readonly IIlanImarTapuDurumu _ilanImarTapuDurumu;
        private readonly IIlanResimler _ilanResimler;
        private readonly IIlanImarDurumu _ilanImarDurumu;
        private readonly IIlanKonutTipiOzellikler _ilanTipOzellikler;
        private readonly IIlanKullanimAmaci _ilanIsyeriTipi;
        private readonly IEmlakLocation _ilanLocation;

        public readonly IIlanKimden _ilanKimden;
        TorbaliBuradaCodeModel _db;
        public IlanlarIlanEngine(IIlanIlanlar ilanIlanlar, IIlanlarEmlakGenel genel, IIlanlarIcOzellikler icOzellikler, IIlanlarDisOzellikler disOzellikler, IEmlakKategoriler emlakKategoriler, IIlanKonutTipiOzellikler emlakTip, IIlanKullanimAmaci ilanKullanimAmaci, IIlanImarTapuDurumu ilanImarTapuDurumu,IIlanResimler ilanResimler, IIlanImarDurumu ilanImarDurumu, IIlanKonutTipiOzellikler ilanTipOzellikler,IIlanKullanimAmaci ilanIsyeriTipi,IIlanKimden ilanKimden, IEmlakLocation ilanLocation)
        {
            _ilanIlanlar = ilanIlanlar;
            _genel = genel;
            _icOzellikler = icOzellikler;
            _disOzellikler = disOzellikler;
            _emlakKategoriler = emlakKategoriler;
            _emlakTip = emlakTip;
            _ilanKullanimAmaci = ilanKullanimAmaci;
            _ilanImarTapuDurumu = ilanImarTapuDurumu;
            _ilanResimler = ilanResimler;
            _ilanImarDurumu = ilanImarDurumu;
            _ilanTipOzellikler = ilanTipOzellikler;
            _ilanIsyeriTipi = ilanIsyeriTipi;
            _ilanLocation = ilanLocation;
           
            _ilanKimden = ilanKimden;
            _db = new TorbaliBuradaCodeModel();
        }
        //İlan Ekle
        public Task<IlanIlanlarResponse> CreateAsync(EmlakIlanRequest request)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                #region İlan Genel Özellikler
                IlanRequest ilan = new IlanRequest();
                ilan.Baslik = request.Baslik;
                ilan.Aciklama = request.Aciklama;
                // var roundedResult = Math.Round(Convert.ToDouble(request.Fiyat.Insert(1,"."), 2);
                ilan.Fiyat = Convert.ToDecimal(request.Fiyat); //.Replace(".",",")                
                ilan.MetreKare = request.MetreKare;                
                ilan.UserName = request.UserName;
                ilan.Private = request.Private;
                ilan.CepTelefonu = request.CepTelefonu;                
                ilan.Sahibi = request.Sahibi;                
                ilan.IletisimTelefonu = request.IletisimTelefonu;
                #region Satılık Devren
                if (request.SatilikId == 2 || request.SatilikId == 4)
                {
                    ilan.TakasliID = request.TakasliID;
                    ilan.TakasTuru = request.TakasTuru;
                }
                #endregion 
                #region Satılık
                if (request.SatilikId == 2 )
                {
                    ilan.Ada = request.Ada;
                    ilan.Pafta = request.Pafta;
                    ilan.Parsel = request.Parsel;
                }
                #endregion
                var ilanlarIlan = Mapper.Map<IlanIlanlar>(ilan);
                #region Ilan Root kategori
                //Satılık Kiralı Devren
                int tur = request.SatilikId;
                var turu = await _emlakKategoriler.GetAsync(tur);
                //Konut İşyeri Arsa
                int tip = request.IlanTuru;
                var tipi = await _emlakKategoriler.GetAsync(tip);

                ilanlarIlan.EmlakKategoriler.Add(turu);
                ilanlarIlan.EmlakKategoriler.Add(tipi);
                #endregion
                #region Semt Mahalle Ilçe
                int ilce = request.id;
                var getIlce = await _ilanLocation.GetAsync(ilce);
                ilanlarIlan.EmlakLocation.Add(getIlce);

                int semt = request.SemtId;
                var getSemt = await _ilanLocation.GetAsync(semt);
                ilanlarIlan.EmlakLocation.Add(getSemt);

                int mahalle = request.MahalleId;
                var getMahalle = await _ilanLocation.GetAsync(mahalle);

                ilanlarIlan.EmlakLocation.Add(getMahalle);
                #endregion
                _ilanIlanlar.Add(ilanlarIlan);
                await _ilanIlanlar.SaveChangeAsync();
                #endregion

                #region Ilan Kimden
                IlanKimdenRequest ilanKimden = new IlanKimdenRequest();
                ilanKimden.KimdemID = request.IlanKimden;
                ilanKimden.EmlakIlanID = ilanlarIlan.Id;

                var ilanKmd = Mapper.Map<IlanKimden>(ilanKimden);
                _ilanKimden.Add(ilanKmd);
                await _ilanKimden.SaveChangeAsync();
                #endregion

                #region Konut Özellikler
                if (tip == 5 || tip == 11)
                {
                    IlanKonutTipiOzelliklerRequest konutTipi = new IlanKonutTipiOzelliklerRequest();
                    konutTipi.EmlakIlanID = ilanlarIlan.Id;
                    konutTipi.KonutTipiOzellikler = request.KonutTipi;

                    var konuttipi = Mapper.Map<IlanKonutTipiOzellikler>(konutTipi);
                    _emlakTip.Add(konuttipi);
                    await _emlakTip.SaveChangeAsync();

                    IlanlarEmlakGenelRequest genel = new IlanlarEmlakGenelRequest();
                    genel.EmlakIlanID = ilanlarIlan.Id;
                    genel.IsitmaID = request.Isitma;
                    genel.BulunduguKatID = request.BulunduguKat;
                    genel.OdaSayisiID = request.OdaSayisi;

                    var emlakGenel = Mapper.Map<IlanlarEmlakGenel>(genel);
                    _genel.Add(emlakGenel);
                    await _genel.SaveChangeAsync();

                }
                #endregion

                #region İşyeri Özellikler
                if (tip == 6 ||tip ==12)
                {
                    IlanKullanimAmaciRequest ilanKullanim = new IlanKullanimAmaciRequest();
                    ilanKullanim.EmlakIlanID = ilanlarIlan.Id;
                    ilanKullanim.KullanimAmaci = request.EmlakKullanimAmaci;

                    var ilankullanim = Mapper.Map<IlanKullanimAmaci>(ilanKullanim);
                    _ilanKullanimAmaci.Add(ilankullanim);
                    await _ilanKullanimAmaci.SaveChangeAsync();

                    IlanlarEmlakGenelRequest genel = new IlanlarEmlakGenelRequest();
                    genel.EmlakIlanID = ilanlarIlan.Id;
                    genel.IsitmaID = request.Isitma;
                    genel.BulunduguKatID = request.BulunduguKat;
                    // genel.OdaSayisiID = request.OdaSayisi;

                    var emlakGenel = Mapper.Map<IlanlarEmlakGenel>(genel);
                    _genel.Add(emlakGenel);
                    await _genel.SaveChangeAsync();
                }
                #endregion

                #region İşyeri Konut Ortak Özellikler
                if (tip == 5 || tip == 6 ||tip == 11 || tip == 12)
                {
                    IlanIcOzelliklerRequest icOzellikler = new IlanIcOzelliklerRequest();                    
                    string remove = request.IcOzellikler.Replace("[","").Replace("]","").Trim();
                    string[] temp = remove.Split(',');
                    if (temp.Any())
                    {
                        foreach (var item in temp)
                        {
                            icOzellikler.EmlakIlanID = ilanlarIlan.Id;
                            icOzellikler.IcOzellikler = item;

                            var ilanicozellikler = Mapper.Map<IlanIcOzellikler>(icOzellikler);
                            _icOzellikler.Add(ilanicozellikler);
                            await _icOzellikler.SaveChangeAsync();
                        }
                    }
                    
                    IlanDisOzelliklerRequest disOzellikler = new IlanDisOzelliklerRequest();
                    string removedis = request.DisOzellikler.Replace("[", "").Replace("]", "").Trim();
                    string[] tempdis = removedis.Split(',');
                    if (tempdis.Any())
                    {
                        foreach (var item in tempdis)
                        {
                            disOzellikler.EmlakIlanID = ilanlarIlan.Id;
                            disOzellikler.DisOzellikler = item;

                            var ilandisozellikler = Mapper.Map<IlanDisOzellikler>(disOzellikler);
                            _disOzellikler.Add(ilandisozellikler);
                            await _disOzellikler.SaveChangeAsync();
                        }
                    }
                    
                    
                }
                #endregion

                #region Arsa özellikler
                if (tip == 7 ||tip == 8 || tip == 10 || tip == 9 || tip == 13 || tip == 14 || tip == 15 || tip == 16)
                {
                    IlanImarTapuDurumuRequest tapu = new IlanImarTapuDurumuRequest();
                    tapu.EmlakIlanID = ilanlarIlan.Id;
                   // tapu.ImarDurumID = request.EmlakImarDurumu;
                    tapu.TapuDurumId = request.EmlakTapuDurumu;
                    var tapudurumu = Mapper.Map<IlanImarTapuDurumu>(tapu);
                    _ilanImarTapuDurumu.Add(tapudurumu);
                    await _ilanImarTapuDurumu.SaveChangeAsync();

                    IlanImarDurumuRequest imar = new IlanImarDurumuRequest();
                    imar.EmlakIlanID = ilanlarIlan.Id;
                    // tapu.ImarDurumID = request.EmlakImarDurumu;
                    imar.ImarDurumID = request.EmlakImarDurumu;
                    var imardurumu = Mapper.Map<IlanImarDurumu>(imar);
                    _ilanImarDurumu.Add(imardurumu);
                    await _ilanImarDurumu.SaveChangeAsync();
                }
                #endregion

                return Mapper.Map<IlanIlanlarResponse>(ilanlarIlan);
            });
        }
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<IlanIlanlarResponse>> GetAllAsync(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public Task<List<IlanIlanlarResponse>> GetAllIlanlarAsync(SerchRequest request)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {

                var binayasi = _ilanIlanlar.GetParametre(x => x.UserName == request.userName).OrderByDescending(x => x.Id);
                return Mapper.Map<List<IlanIlanlarResponse>>(await binayasi.ToListAsync());
            });
        }

        public Task<IlanIlanlarResponse> GetAsync(int id)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                IlanIlanlarResponse yeni = new IlanIlanlarResponse();
                var ilan = await _ilanIlanlar.GetAsync(id);
                yeni.Aciklama = ilan.Aciklama;
                yeni.Baslik = ilan.Baslik;
                yeni.Fiyat = ilan.Fiyat;
                yeni.Id = ilan.Id;
                yeni.IlanKimden = ilan.IlanKimden.First().EmlakKimden.Kimden;
                yeni.IletisimTelefonu = ilan.IletisimTelefonu;
                yeni.MetreKare = ilan.MetreKare;
                yeni.Private = ilan.Private;
                yeni.Takasli = ilan.TakasliID;
                yeni.TakasTuru = ilan.TakasTuru;
                yeni.UserName = ilan.UserName;
                yeni.IlanSahibi = ilan.Sahibi;
                yeni.Ada = ilan.Ada;
                yeni.Parsel = ilan.Parsel;
                yeni.Pafta = ilan.Pafta;
                yeni.IlanSahibiCepTelefonu = ilan.CepTelefonu;
                return Mapper.Map<IlanIlanlarResponse>(yeni);
            });
        }

        public async Task<List<IlanResponse>> SearchAsync(SerchRequest request)
        {
            return await base.ExecuteWithExceptionHandledOperation(async () =>
            {
                if (request.take == 0)
                {
                    request.take = ConfigurationHelper.DefaultTakeListMinCount;
                }
                var search = _ilanIlanlar.GetAll(request.skip, request.take);
                if (!string.IsNullOrEmpty(request.userName))
                {
                    search = search.Where(x => x.UserName.Contains(request.userName));
                }

                return Mapper.Map<List<IlanResponse>>(await search.ToListAsync());

            });
        }

        public Task<IlanUpdateResponse> UpdateAsync(UpdateIlanRequest request)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var ilanUpdt = Mapper.Map<IlanIlanlar>(request);
                _ilanIlanlar.Update(ilanUpdt);
                await _ilanIlanlar.SaveChangeAsync();
                return Mapper.Map<IlanUpdateResponse>(ilanUpdt);
            });
        }

        public async Task<List<IlanResponse>> SearchTotalPageAsync(SerchRequest request)
        {
            return await base.ExecuteWithExceptionHandledOperation(async () =>
            {
                            
                var search = _ilanIlanlar.GetAll();
                return Mapper.Map<List<IlanResponse>>(await search.ToListAsync());
            });
        }
        public Task<TotalPageSearchResponse> TotalPageAsync(SerchRequest request)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                int pageSize = 5;
                List<KategoriSearch> ddd = new List<KategoriSearch>();
                List<IlanIlanlarResponse> listIlanlar = new List<IlanIlanlarResponse>();
                List<KategoriSearch> listKategori = new List<KategoriSearch>();
                List<EmlakLocationResponse> listAdresler = new List<EmlakLocationResponse>();
                TotalPageSearchResponse total = new TotalPageSearchResponse();
                List<IlanIlanlar> ilanllanlar = new List<IlanIlanlar>();

                if(request.id!=0)
                {
                    AramaFabrikasi fabrika = new AramaFabrikasi();
                    ISearch arama = fabrika.AramaNesnesiOlustur(request);
                    await arama.SearchQuery(_ilanLocation, _emlakKategoriler,total, listIlanlar, listAdresler, request);
                    
                }

              
                else
                {
                    if(total.totalRecord<=0)
                        total.totalRecord = _ilanIlanlar.GetAll().Count();
                    if(total.totalPage<=0)
                        total.totalPage = (total.totalRecord / pageSize) + ((total.totalRecord % pageSize) > 0 ? 1 : 0);
                    total.currentPage = request.page;
                    int skip = (request.page - 1) * pageSize;
                    // .Skip((request.page - 1) * pageSize).Take(pageSize)
                    var kat = await _ilanIlanlar.GetAll(skip, pageSize).Where(x => x.Private == "Genel").ToListAsync();
                   // var kat = await _emlakKategoriler.GetAll();
                   // var ilan = kat.IlanIlanlar.Where(x => x.Private == "Genel");
                    foreach (var item in kat)
                    {
                        listAdresler.Clear();
                        foreach (var adres in item.EmlakLocation)
                        {                            
                            listAdresler.Add(new EmlakLocationResponse
                            {
                                LocationName = adres.LocationName
                            });
                        }
                        string resim = (item.IlanResimler.Count() > 0 ? item.IlanResimler.First().Resim: "noimages.jpg");
                        string ilanKimden = item.IlanKimden.First().EmlakKimden.Kimden;
                        listIlanlar.Add(new IlanIlanlarResponse {
                            Id = item.Id,
                            Baslik = item.Baslik,
                            Aciklama = item.Aciklama,
                            Fiyat = item.Fiyat,
                            MetreKare = item.MetreKare,
                            Takasli = item.TakasliID,
                            TakasTuru = item.TakasTuru,
                            Resim = resim,
                            IletisimTelefonu = item.IletisimTelefonu,
                            IlanKimden= ilanKimden,
                            Location = listAdresler
                        });
                    }


                    //total.Adresler = listAdresler;
                    //total.NewSearchList = listKategori;
                    total.Ilanlar = listIlanlar;

                }

                return Mapper.Map<TotalPageSearchResponse>(total);
            });

        }

        public async Task<TotalPageSearchResponse> TestGetMethod(SerchRequest request)
        {
            int pageSize = 3;
            TotalPageSearchResponse total = new TotalPageSearchResponse();
            total.totalRecord = _ilanIlanlar.GetAll().Count();
            //total.totalRecord = search.Count();
            total.currentPage = request.page;
            total.totalPage = (total.totalRecord / pageSize) + ((total.totalRecord % pageSize) > 0 ? 1 : 0);
            var a = await _ilanIlanlar.GetAll().Skip((request.page - 1) * pageSize).Take(pageSize).ToListAsync();
            foreach (var item in a)
            {
                total.Ilanlar.Add(new IlanIlanlarResponse { Baslik = item.Baslik, Aciklama = item.Aciklama, Id = item.Id, Fiyat = item.Fiyat });
            }
            
            return Mapper.Map<TotalPageSearchResponse>(total);
        }

        Task<List<TotalPageSearchResponse>> IIlanlarIlanEngine.SearchTotalPageAsync(SerchRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<TotalPageSearchResponse> SearchTotalPageEmlakAsync(SerchRequest request)
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                //request.id = 3;
                int pageSize = 2;
                
                List<KategoriSearch> listKategori = new List<KategoriSearch>();
                TotalPageSearchResponse total = new TotalPageSearchResponse();                

                var kat = await _emlakKategoriler.GetAsync(request.id);
                total.totalRecord = kat.IlanIlanlar.Count();
                total.totalPage = (total.totalRecord / pageSize) + ((total.totalRecord % pageSize) > 0 ? 1 : 0);
                total.currentPage = request.page;
                int skip = (request.page - 1) * pageSize;
                var ilan = kat.IlanIlanlar.Skip(skip).Take(pageSize).Where(x => x.Private == "Genel");
                foreach (var item in ilan)
                {
                    listKategori.Add(new KategoriSearch { Id=item.Id, Baslik=item.Baslik , Resim=item.IlanResimler.First().Resim});
                }
              //  total.NewSearchList = listKategori;
                
                                 

                return Mapper.Map<TotalPageSearchResponse>(total);
            });
        }
    }
}
