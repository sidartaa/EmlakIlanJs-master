using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
    public class EmlakIcOzellliklerEngine : BusinessEngineBase, IEmlakIcOzelliklerEngine
    {
        private readonly IEmlakIcOzellikler _emlakIcOzelliklerRepostory;
        public EmlakIcOzellliklerEngine(IEmlakIcOzellikler emlakIcOzelliklerRepostory)
        {
            _emlakIcOzelliklerRepostory = emlakIcOzelliklerRepostory;
        }

        public Task<List<EmlakIcOzelliklerResponse>> GetAllEmlakIcOzelliklerAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var emlakicozellikler = _emlakIcOzelliklerRepostory.GetAll();
                return Mapper.Map<List<EmlakIcOzelliklerResponse>>(await emlakicozellikler.ToListAsync());
            });
        }
    }
}
