using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{
    public class EmlakYapiDurumuController : ApiController
    {
        private readonly IEmlakYapiDurumuEngine _emlakYapiDurumu;
        public EmlakYapiDurumuController(IEmlakYapiDurumuEngine emlakYapiDurumu)
        {
            _emlakYapiDurumu = emlakYapiDurumu;
        }
        [HttpGet]
        public Task<List<EmlakYapiDurumuResponse>> EmlakYapiDurumu()
        {
            return _emlakYapiDurumu.GetAllEmlakYapiDurumuAsync();
        }
    }
}
