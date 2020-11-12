using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class EmlakIlanTipiEngine : BusinessEngineBase, IEmlakIlanTipiEngine
    {
        private readonly IEmlakIlanTipi _emlakIlanTipiRepostory;
        public EmlakIlanTipiEngine(IEmlakIlanTipi emlakIlanTipiRepostory)
        {
            _emlakIlanTipiRepostory = emlakIlanTipiRepostory;
        }
        public Task<List<EmlakIlanTipiResponse>> GetAllEmlakIlanTipiAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () => 
            {
                var emlakilantipi = _emlakIlanTipiRepostory.GetAll();
                return Mapper.Map<List<EmlakIlanTipiResponse>>(await emlakilantipi.ToListAsync());
            });

        }
    }
}
