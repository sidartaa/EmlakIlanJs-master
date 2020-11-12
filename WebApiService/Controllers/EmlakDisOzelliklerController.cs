using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{
    public class EmlakDisOzelliklerController : ApiController
    {
        private readonly IEmlakDisOzelliklerEngine _emlakDisOzellikler;
        public EmlakDisOzelliklerController(IEmlakDisOzelliklerEngine emlakDisOzellikler)
        {
            _emlakDisOzellikler = emlakDisOzellikler;
        }
        [HttpGet]
        public Task<List<EmlakDisOzelliklerResponse>> EmlakDisOzellikleri()
        {
            return _emlakDisOzellikler.GetAllEmlakDisOzelliklerAsync();
        }
    }
}
