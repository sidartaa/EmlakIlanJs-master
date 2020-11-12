using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class EmlakCepheEngine : BusinessEngineBase, IEmlakCepheEngine
    {
        private readonly IEmlakCephe _emlakCepheRepostory;
        public EmlakCepheEngine(IEmlakCephe emlakCepheRepostory)
        {
            _emlakCepheRepostory = emlakCepheRepostory;
        }
        public Task<List<EmlakCepheResponse>> GetAllEmlakCephesiAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var emlakcephe = _emlakCepheRepostory.GetAll();
                return Mapper.Map<List<EmlakCepheResponse>>(await emlakcephe.ToListAsync());
            });
        }
    }
}
