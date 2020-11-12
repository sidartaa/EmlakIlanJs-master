using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class ArsaManzaraEngine : BusinessEngineBase, IArsaManzaraEngine
    {
        private readonly IArsaKonumu _arsaKonumuRepostory;
        public ArsaManzaraEngine(IArsaKonumu arsaKonumuRepostory)
        {
            _arsaKonumuRepostory = arsaKonumuRepostory;
        }
        public Task<List<ArsaManzaraResponse>> GetAllArsaManzaraAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var arsamanzara = _arsaKonumuRepostory.GetAll();
                return Mapper.Map<List<ArsaManzaraResponse>>(await arsamanzara.ToListAsync());
            });
        }
    }
}
