using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class ArsaKonumEngine : BusinessEngineBase, IArsaKonumEngine
    {
        private readonly IArsaKonumu _arsaKonumRepostory;
        public ArsaKonumEngine(IArsaKonumu arsaKonumRepostory)
        {
            _arsaKonumRepostory = arsaKonumRepostory;
        }
        Task<List<ArsaKonumuResponse>> IArsaKonumEngine.GetAllArsaKonumiAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var binayasi = _arsaKonumRepostory.GetAll();
                return Mapper.Map<List<ArsaKonumuResponse>>(await binayasi.ToListAsync());
            });
        }
    }
}
