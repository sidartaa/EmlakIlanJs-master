using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{
    public class EmlakMuhitController : ApiController
    {
        private readonly IEmlakMuhitEngine _emlakMuhit;
        public EmlakMuhitController(IEmlakMuhitEngine emlakMuhit)
        {
            _emlakMuhit = emlakMuhit;
        }
        [HttpGet]
        public Task<List<EmlakMuhitResponse>> EmlakMuhit()
        {
            return _emlakMuhit.GetAllEmlakMuhitAsync();
        }
    }
}
