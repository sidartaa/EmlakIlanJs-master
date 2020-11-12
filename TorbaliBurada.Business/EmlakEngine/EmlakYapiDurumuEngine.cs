using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class EmlakYapiDurumuEngine : BusinessEngineBase,IEmlakYapiDurumuEngine
    {
        private readonly IEmlakYapiDurumu _emlakYapiDurumuRepostory;
        public EmlakYapiDurumuEngine(IEmlakYapiDurumu emlakYapiDurumuRepostory)
        {
            _emlakYapiDurumuRepostory = emlakYapiDurumuRepostory;
        }
        public Task<List<EmlakYapiDurumuResponse>> GetAllEmlakYapiDurumuAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var emlakyapidurumu = _emlakYapiDurumuRepostory.GetAll();
                return Mapper.Map<List<EmlakYapiDurumuResponse>>(await emlakyapidurumu.ToListAsync());
            });
        }
    }
}
