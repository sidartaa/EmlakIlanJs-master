using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class EmlakMuhitEngine : BusinessEngineBase, IEmlakMuhitEngine
    {
       private readonly IEmlakMuhit _emlakMuhitRepostory;
        public EmlakMuhitEngine(IEmlakMuhit emlakMuhitRepostory)
        {
            _emlakMuhitRepostory = emlakMuhitRepostory;
        }
        public Task<List<EmlakMuhitResponse>> GetAllEmlakMuhitAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var emlakmuhit = _emlakMuhitRepostory.GetAll();
                return Mapper.Map<List<EmlakMuhitResponse>>(await emlakmuhit.ToListAsync());
            });
        }
    }
}
