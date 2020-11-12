using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class EmlakYapiTipiEngine:BusinessEngineBase,IEmlakYapiTipiEngine
    {
        private readonly IEmlakYapiTipi _emlakYapiTipiRepostory;
        public EmlakYapiTipiEngine(IEmlakYapiTipi emlakYapiTipiRepostory)
        {
            _emlakYapiTipiRepostory = emlakYapiTipiRepostory;
        }

        public Task<List<EmlakYapiTipiResponse>> GetAllEmlakYapiTipiAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var emlakyapitipi = _emlakYapiTipiRepostory.GetAll();
                return Mapper.Map<List<EmlakYapiTipiResponse>>(await emlakyapitipi.ToListAsync());
            });
        }
    }
}
