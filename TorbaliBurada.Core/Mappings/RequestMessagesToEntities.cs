using AutoMapper;
using Torbali.Core.Common.Contracts.RequestMessages;
using Torbali.Core.Common.Contracts.RequestMessages.IlanAdresler;
using Torbali.Core.Common.Contracts.RequestMessages.IlanKategori;
using Torbali.Core.Common.Contracts.RequestMessages.IlanKimden;
using Torbali.Core.Common.Contracts.RequestMessages.Ilanlar;
using Torbali.Core.Common.Contracts.RequestMessages.IlanResimler;
using Torbali.Core.Common.Contracts.RequestMessages.Musteriler;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Data.CodeFirst.Entity;

namespace TorbaliBurada.Core.Mappings
{
    public  class RequestMessagesToEntities
    {
        public static void Map(IMapperConfigurationExpression mapperConfiguration)
        {
            mapperConfiguration.CreateMap<BinaYasiRequest,EmlakBinaYasi>();
            mapperConfiguration.CreateMap<ArsaGenelOzellikleriRequest, ArsaGenelOzelikleri>();
            mapperConfiguration.CreateMap<IlanRequest, IlanIlanlar>();
            mapperConfiguration.CreateMap<EmlakKategorilerRequest, EmlakKategoriler>();
            mapperConfiguration.CreateMap<IlanlarEmlakGenelRequest, IlanlarEmlakGenel>();
            mapperConfiguration.CreateMap<IlanIcOzelliklerRequest, IlanIcOzellikler>();
            mapperConfiguration.CreateMap<IlanDisOzelliklerRequest, IlanDisOzellikler>();
            mapperConfiguration.CreateMap<IlanResimlerRequeste, IlanResimler>();
            mapperConfiguration.CreateMap<IlanKonutTipiOzelliklerRequest, IlanKonutTipiOzellikler>();
            mapperConfiguration.CreateMap<IlanKullanimAmaciRequest, IlanKullanimAmaci>();
            mapperConfiguration.CreateMap<IlanImarTapuDurumuRequest, IlanImarTapuDurumu>();
            mapperConfiguration.CreateMap<IlanImarDurumuRequest, IlanImarDurumu>();
            mapperConfiguration.CreateMap<UpdateIlanRequest, IlanIlanlar>();           
            mapperConfiguration.CreateMap<IlanKimdenRequest , IlanKimden>();
            mapperConfiguration.CreateMap<MusterilerRequest, MusteriList>();
            mapperConfiguration.CreateMap<MusterilerUpdateRequest, MusteriList>();
            mapperConfiguration.CreateMap<MusterilerResponse, MusteriList>();


        }
    }
}
