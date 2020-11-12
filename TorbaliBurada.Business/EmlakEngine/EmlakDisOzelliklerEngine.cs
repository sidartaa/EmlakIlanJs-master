using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class EmlakDisOzelliklerEngine: BusinessEngineBase,IEmlakDisOzelliklerEngine
    {
        private readonly IEmlakDisOzellikler _emlakDisOzellikler;
        public EmlakDisOzelliklerEngine(IEmlakDisOzellikler emlakDisOzellikler)
        {
            _emlakDisOzellikler = emlakDisOzellikler;
        }

        public Task<List<EmlakDisOzelliklerResponse>> GetAllEmlakDisOzelliklerAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var emlakDisOzellikler = _emlakDisOzellikler.GetAll();
                return Mapper.Map<List<EmlakDisOzelliklerResponse>>(await emlakDisOzellikler.ToListAsync());
            });
        }
    }
}
