using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{
    public class EmlakIsitmaTuruController : ApiController
    {
        private readonly IEmlakIsıtmaTuruEngine _emlakIsitmaTuru;
        public EmlakIsitmaTuruController(IEmlakIsıtmaTuruEngine emlakIsitmaTuru )
        {
            _emlakIsitmaTuru = emlakIsitmaTuru;
        }
        [HttpGet]
        public Task<List<EmlakIsitmaTuruResonse>> EmlakIsitmaTuru()
        {
            return _emlakIsitmaTuru.GetAllEmlakIsitmaTuruAsync();
        }
    }
}
