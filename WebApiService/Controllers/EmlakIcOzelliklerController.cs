using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{
    public class EmlakIcOzelliklerController : ApiController
    {
        private readonly IEmlakIcOzelliklerEngine _emlakIcOzellikler;
        public EmlakIcOzelliklerController(IEmlakIcOzelliklerEngine emlakIcOzellikler)
        {
            _emlakIcOzellikler = emlakIcOzellikler;
        }
        [HttpGet]
        public Task<List<EmlakIcOzelliklerResponse>> EmlakIcOzellikleri()
        {
            return _emlakIcOzellikler.GetAllEmlakIcOzelliklerAsync();
        }
    }
}
