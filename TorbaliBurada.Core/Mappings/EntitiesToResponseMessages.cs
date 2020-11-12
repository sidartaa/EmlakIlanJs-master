using AutoMapper;
using Torbali.Core.Common.Contracts.RequestMessages.IlanAdresler;
using Torbali.Core.Common.Contracts.RequestMessages.IlanKimden;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Data.CodeFirst.Entity;

namespace TorbaliBurada.Core.Mappings
{
    public class EntitiesToResponseMessages
    {
        public static void Map(IMapperConfigurationExpression mapperConfiguration)
        {
            mapperConfiguration.CreateMap<EmlakBinaYasi, EmlakBinaYasiResponse>();
            mapperConfiguration.CreateMap<ArsaGenelOzelikleri, ArsaGenelOzellikleriResponse>();
            mapperConfiguration.CreateMap<ArsaKonumu, ArsaKonumuResponse>();
            mapperConfiguration.CreateMap<ArsaManzara, ArsaManzaraResponse>();
            mapperConfiguration.CreateMap<EmlakAltyapi,EmlakAltyapiResponse>();
            mapperConfiguration.CreateMap<EmlakBanyoSayisi,EmlakBanyoSayisiResponse>();
            mapperConfiguration.CreateMap<EmlakBulunduguKat,EmlakBulunduguKatResponse>();
            mapperConfiguration.CreateMap<EmlakCephe,EmlakCepheResponse>();
            mapperConfiguration.CreateMap<EmlakDisOzellikler,EmlakDisOzelliklerResponse>();
            mapperConfiguration.CreateMap<EmlakGenelOzellikler,EmlakGenelOzelliklerResponse>();
            mapperConfiguration.CreateMap<EmlakIcOzellikler,EmlakIcOzelliklerResponse>();
            mapperConfiguration.CreateMap<EmlakIlanTipi,EmlakIlanTipiResponse>();
            mapperConfiguration.CreateMap<EmlakImarDurumu,EmlakImarDurumuResponse>();
            mapperConfiguration.CreateMap<EmlakIsitmaTuru,EmlakIsitmaTuruResonse>();
            mapperConfiguration.CreateMap<EmlakKategoriler,EmlakKategoilerResponse>();
            mapperConfiguration.CreateMap<EmlakKatSayisi,EmlakKatSayisiResponse>();
            mapperConfiguration.CreateMap<EmlakKimden,EmlakKimdenResponse>();
            mapperConfiguration.CreateMap<EmlakKonutTipi,EmlakKonutTipiResponse>();
            mapperConfiguration.CreateMap<EmlakKullanimAmaci,EmlakKullanimAmaciResponse>();
            mapperConfiguration.CreateMap<EmlakKullanimDurumu,EmlakKullanimDurumuResponse>();
            mapperConfiguration.CreateMap<EmlakLocation,EmlakLocationResponse>();
            mapperConfiguration.CreateMap<EmlakManzara,EmlakManzaraResponse>();
            mapperConfiguration.CreateMap<EmlakMuhit,EmlakMuhitResponse>();
            mapperConfiguration.CreateMap<EmlakOdaSayisi,EmlakOdaSayisiResponse>();
            mapperConfiguration.CreateMap<EmlakTakasli,EmlakTakasliResponse>();
            mapperConfiguration.CreateMap<EmlakTapuDurumu,EmlakTapuDurumuResponse>();
            mapperConfiguration.CreateMap<EmlakUlasim,EmlakUlasimResponse>();
            mapperConfiguration.CreateMap<EmlakYapiDurumu,EmlakYapiDurumuResponse>();
            mapperConfiguration.CreateMap<EmlakYapiTipi,EmlakYapiTipiResponse>();
            mapperConfiguration.CreateMap<EmlakSiteIcerisinde, EmlakSiteIcerisindeResponse>();
            mapperConfiguration.CreateMap<IlanIlanlar, IlanResponse>();
            mapperConfiguration.CreateMap<IlanlarEmlakGenel, IlanEmlakGenelResponse>();
            mapperConfiguration.CreateMap<IlanDisOzellikler, IlanDisOzelliklerResponse>();
            mapperConfiguration.CreateMap<IlanIlanlar, IlanIlanlarResponse>();
            mapperConfiguration.CreateMap<IlanIlanlar, IlanUpdateResponse>();
            mapperConfiguration.CreateMap<IlanResimler, IlanResimlerResponse>();
            mapperConfiguration.CreateMap<IlanKonutTipiOzellikler, IlanKonutTipiOzelliklerResponse>();
            mapperConfiguration.CreateMap<IlanKullanimAmaci, IlanKullanimAmaciResponse>();
            mapperConfiguration.CreateMap<IlanImarTapuDurumu, IlanImarTapuDurumuResponse>();
            mapperConfiguration.CreateMap<IlanIlanlar, TotalPageSearchResponse>();
            mapperConfiguration.CreateMap<IlanImarDurumu, IlanImarDurumuResponse>();
            mapperConfiguration.CreateMap<IlanKimden, IlanKimdenResponse>();
            mapperConfiguration.CreateMap<EmlakLocation, EmlakLocationCheckResponse>();
            mapperConfiguration.CreateMap<MusteriList, MusterilerResponse>();
            mapperConfiguration.CreateMap<MusteriList, MusterilerListResponse>();



        }
    }
}
