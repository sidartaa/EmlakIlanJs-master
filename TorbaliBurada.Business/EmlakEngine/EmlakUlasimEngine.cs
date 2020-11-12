using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class EmlakUlasimEngine : BusinessEngineBase, IEmlakUlasimEngine
    {
        private readonly IEmlakUlasim _emlakUlasimRepostory;
        public EmlakUlasimEngine(IEmlakUlasim emlakUlasimRepostory)
        {
            _emlakUlasimRepostory = emlakUlasimRepostory;
        }
        public Task<List<EmlakUlasimResponse>> GetAllEmlakUlasimResponseAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var emlakulasim = _emlakUlasimRepostory.GetAll();
                return Mapper.Map<List<EmlakUlasimResponse>>(await emlakulasim.ToListAsync());
            });
        }
    }
}
