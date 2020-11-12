using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{
    public class EmlakYapiTipiController : ApiController
    {
        private readonly IEmlakYapiTipiEngine _emlakYapiTipi;
        public EmlakYapiTipiController(IEmlakYapiTipiEngine emlakYapiTipi)
        {
            _emlakYapiTipi = emlakYapiTipi;
        }
        [HttpGet]
        public Task<List<EmlakYapiTipiResponse>> EmlakYapiTipi()
        {
            return _emlakYapiTipi.GetAllEmlakYapiTipiAsync();
        }
    }
}
