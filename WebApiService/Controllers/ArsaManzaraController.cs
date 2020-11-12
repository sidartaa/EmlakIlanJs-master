using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{
    public class ArsaManzaraController : ApiController
    {
        private readonly IArsaManzaraEngine _arsaManzara;
        public ArsaManzaraController(IArsaManzaraEngine arsaManzara)
        {
            _arsaManzara = arsaManzara;
        }
        [HttpGet]
        public Task<List<ArsaManzaraResponse>> ArsaManzara()
        {
            return _arsaManzara.GetAllArsaManzaraAsync();
        }
    }
}
