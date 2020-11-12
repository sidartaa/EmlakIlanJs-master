using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class EmlakTakasliEngine : BusinessEngineBase, IEmlakTakasliEngine
    {
        private readonly IEmlakTakasli _emlakTakasliRepostory;
        public EmlakTakasliEngine(IEmlakTakasli emlakTakasliRepostory)
        {
            _emlakTakasliRepostory = emlakTakasliRepostory;
        }
        public Task<List<EmlakTakasliResponse>> GetAllEmlakTakaslieAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var emlaktakasli = _emlakTakasliRepostory.GetAll();
                return Mapper.Map<List<EmlakTakasliResponse>>(await emlaktakasli.ToListAsync());
            });
        }
    }
}
