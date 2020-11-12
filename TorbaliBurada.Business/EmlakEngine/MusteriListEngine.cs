using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using TorbaliBurada.Business.Contracts.IEmlakEngine;
using Torbali.Core.Common.Contracts.ResponseMessages;
using Torbali.Core.Common.Contracts.RequestMessages.Musteriler;
using TorbaliBurada.Data.CodeFirst.Entity;
using TorbaliBurada.Entity.Contracts;


namespace TorbaliBurada.Business.EmlakEngine
{
    public class MusteriListEngine : BusinessEngineBase, IMusteriListEngine
    {
        private readonly IMusteriList _musteriList;
        private readonly IEmlakKategoriler _emlakKategoriler;
        private readonly IEmlakLocation _emlakLocation;
        private static MusterilerListResponse total;
        private static List<MusterilerResponse> liste;
        private static  List<IlanResponse> kategoriIlan;
        private  List<IlanResponse> locationIlan;
        public MusteriListEngine(IMusteriList musteriList,IEmlakKategoriler emlakKategoriler,IEmlakLocation emlakLocation)
        {
            _musteriList = musteriList;
            _emlakKategoriler = emlakKategoriler;
            _emlakLocation = emlakLocation;
        }
        public Task<MusterilerResponse> CreateAsync(MusterilerListInsertRequest request)
        {
            return  base.ExecuteWithExceptionHandledOperation(async () =>
            {
                MusterilerResponse musteri = new MusterilerResponse();
                musteri.Ad = request.Ad;
                musteri.CepTelefonu = request.CepTelefonu;
                musteri.Email = request.Email;
                musteri.EnDusukFiyat = request.EnDusukFiyat;
                musteri.EnYuksekFiyat = request.EnYuksekFiyat;
                musteri.Soyad = request.Soyad;
                var query = Mapper.Map<MusteriList>(musteri);
                _musteriList.Add(query);

                string kat = request.Kategori.Replace("[", "").Replace("]", "").Trim();
                string[] temp = kat.Split(',');
                foreach (var item in temp)
                {
                    int tur = Convert.ToInt32(item);
                    var turu = await _emlakKategoriler.GetAsync(tur);
                    query.EmlakKategoriler.Add(turu);
                }

                string loc = request.Location.Replace("[", "").Replace("]", "").Trim();
                string[] locp = kat.Split(',');
                foreach (var item in locp)
                {
                    int tur = Convert.ToInt32(item);
                    var turu = await _emlakLocation.GetAsync(tur);
                    query.EmlakLocation.Add(turu);
                }
                string ttur = request.Tur.Replace("[","").Replace("]","").Trim();
                string[] tlop = ttur.Split(',');
                foreach (var item in tlop)
                {
                    int t = Convert.ToInt32(item);
                    var tur = await _emlakKategoriler.GetAsync(t);
                    query.EmlakKategoriler.Add(tur);
                }

                string semt = request.Semt.Replace("[", "").Replace("]", "").Trim();
                string[] sem = semt.Split(',');
                foreach (var item in sem)
                {
                    int t = Convert.ToInt32(item);
                    var tur = await _emlakLocation.GetAsync(t);
                    query.EmlakLocation.Add(tur);
                }
                await _musteriList.SaveChangeAsync();
                return Mapper.Map<MusterilerResponse>(query);
            });
        }

        public Task<MusterilerListResponse> GetAllMusterilerAsync(SerchMusteriRequest request)
        {
            return ExecuteWithExceptionHandledOperation(async () =>
            {
              //  MusterilerListResponse total = new MusterilerListResponse();
                //List<MusterilerResponse> liste = new List<MusterilerResponse>();
                if (total == null)
                    total = new MusterilerListResponse();
                if (liste == null)
                    liste = new List<MusterilerResponse>();
                if (kategoriIlan == null)
                    kategoriIlan = new List<IlanResponse>();
                if (locationIlan == null)
                    locationIlan = new List<IlanResponse>();
                    int pageSize = 10;
                if (total.totalRecord <= 0)
                    total.totalRecord = _musteriList.GetAll().Count();
                if (total.totalPage <= 0)
                    total.totalPage = (total.totalRecord / pageSize) + ((total.totalRecord % pageSize) > 0 ? 1 : 0);
                total.currentPage = request.page;
                int skip = (request.page - 1) * pageSize;
                // .Skip((request.page - 1) * pageSize).Take(pageSize)
                var listem= await _musteriList.GetAll(skip, pageSize).ToListAsync();
               
                liste.Clear();
                
                foreach (var item in listem)
                {
                    liste.Add(new MusterilerResponse { Id=item.Id, Ad= item.Ad, CepTelefonu=item.CepTelefonu, Email=item.Email, Soyad=item.Soyad,Statu=item.Statu, CountKategori=item.EmlakKategoriler.Count(), CountLocation=item.EmlakLocation.Count()  });
                 
                }
               
                total.Musteriler = liste;
                
               // total.KategoriIlan = kategoriIlan;
                //total.LocationIlan = locationIlan;
                return Mapper.Map<MusterilerListResponse>(total);
            });
               
        }
    }
}
