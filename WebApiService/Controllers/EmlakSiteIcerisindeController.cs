using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{
    public class EmlakSiteIcerisindeController : ApiController
    {
        private readonly IEmlakSiteIcerisindeEngine _emlakSiteIcerisinde;
        public EmlakSiteIcerisindeController(IEmlakSiteIcerisindeEngine emlakSiteIcerisinde)
        {
            _emlakSiteIcerisinde = emlakSiteIcerisinde;
        }
        [HttpGet]
        public Task<List<EmlakSiteIcerisindeResponse>> EmlakSiteIcerisinde()
        {
            return _emlakSiteIcerisinde.GetAllEmlakSiteIcerisideAsync();
        }
    }
}
