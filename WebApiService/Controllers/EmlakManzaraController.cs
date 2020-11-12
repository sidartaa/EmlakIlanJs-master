using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{
    public class EmlakManzaraController : ApiController
    {
        private readonly IEmlakManzaraEngine _emlakManzara;
        public EmlakManzaraController(IEmlakManzaraEngine emlakManzara)
        {
            _emlakManzara = emlakManzara;
        }
        [HttpGet]
        public Task<List<EmlakManzaraResponse>> EmlakManzara()
        {
            return _emlakManzara.GetAllEmlakManzaraResponseAsync();
        }
    }
}
