using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Entity.Contracts;

namespace TorbaliBurada.Business.EmlakEngine
{
   public class EmlakSiteIcerisindeEngine : BusinessEngineBase, IEmlakSiteIcerisindeEngine
    {
        private readonly IEmlakSiteIcerisinde _emlakSiteIcerisindeRepostory;
        public EmlakSiteIcerisindeEngine(IEmlakSiteIcerisinde emlakSiteIcerisindeRepostory)
        {
            _emlakSiteIcerisindeRepostory = emlakSiteIcerisindeRepostory;
        }
        public Task<List<EmlakSiteIcerisindeResponse>> GetAllEmlakSiteIcerisideAsync()
        {
            return base.ExecuteWithExceptionHandledOperation(async () =>
            {
                var emlaksiteicerisinde = _emlakSiteIcerisindeRepostory.GetAll();
                return Mapper.Map<List<EmlakSiteIcerisindeResponse>>(await emlaksiteicerisinde.ToListAsync());
            });
        }
    }
}
