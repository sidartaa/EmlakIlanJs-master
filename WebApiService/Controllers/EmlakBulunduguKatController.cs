using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{
    public class EmlakBulunduguKatController : ApiController
    {
        private readonly IEmlakBulunduguKatEngine _emlakBulunduguKat;
        public EmlakBulunduguKatController(IEmlakBulunduguKatEngine emlakBulunduguKat)
        {
            _emlakBulunduguKat = emlakBulunduguKat;
        }
        [HttpGet]
        public Task<List<EmlakBulunduguKatResponse>> BulunduguKat()
        {
            return _emlakBulunduguKat.GetAllEmlakBulunduguKatAsync();
        }
    }
}
