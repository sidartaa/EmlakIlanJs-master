using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{
    public class EmlakUlasimController : ApiController
    {
        private readonly IEmlakUlasimEngine _emlakUlasim;
        public EmlakUlasimController(IEmlakUlasimEngine emlakUlasim)
        {
            _emlakUlasim = emlakUlasim;
        }
        [HttpGet]
        public Task<List<EmlakUlasimResponse>> EmlakUlasim()
        {
            return _emlakUlasim.GetAllEmlakUlasimResponseAsync();
        }
    }
}
