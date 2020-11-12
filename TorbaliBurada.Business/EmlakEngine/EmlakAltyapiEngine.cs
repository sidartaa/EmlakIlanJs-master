using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class EmlakAltyapiEngine: BusinessEngineBase,IEmlakAltyapiEngine
    {
        private readonly IEmlakAltyapi _emlakAltyapiRepostory;
        public EmlakAltyapiEngine(IEmlakAltyapi emlakAltyapiRepostory)
        {
            _emlakAltyapiRepostory = emlakAltyapiRepostory;
        }

        public Task<List<EmlakAltyapiResponse>> GetAllEmlakAltyapiAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var emlakaltyapi = _emlakAltyapiRepostory.GetAll();
                return Mapper.Map<List<EmlakAltyapiResponse>>(await emlakaltyapi.ToListAsync());
            });
        }
    }
}
