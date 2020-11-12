using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{
    public class EmlakAltYapiController : ApiController
    {
        private readonly IEmlakAltyapiEngine _emlakAltYapi;
        public EmlakAltYapiController(IEmlakAltyapiEngine emlakAltyapi)
        {
            _emlakAltYapi = emlakAltyapi;
        }
        [HttpGet]
        public Task<List<EmlakAltyapiResponse>> EmlakAltyapi()
        {
            return _emlakAltYapi.GetAllEmlakAltyapiAsync();
        }
    }
}
