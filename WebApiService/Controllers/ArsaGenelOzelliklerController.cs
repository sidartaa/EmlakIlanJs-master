using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{
    public class ArsaGenelOzelliklerController : ApiController
    {
        private readonly IArsaGenelOzellikleriEngine _arsaGenelOzellikler;
        public ArsaGenelOzelliklerController(IArsaGenelOzellikleriEngine arsaGenelOzellikler)
        {
            _arsaGenelOzellikler = arsaGenelOzellikler;
        }
        [HttpGet]
        public Task<List<ArsaGenelOzellikleriResponse>> ArsaGenelOzellikleri()
        {
            return _arsaGenelOzellikler.GetAllArsaGenelOzellikleriAsync();
        }
    }
}
