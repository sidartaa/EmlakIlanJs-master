using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{
    public class EmlakIlanTipiController : ApiController
    {
        private readonly IEmlakIlanTipiEngine _emlakIlanTipi;
        public EmlakIlanTipiController(IEmlakIlanTipiEngine emlakIlanTipi)
        {
            _emlakIlanTipi = emlakIlanTipi;
        }
        [HttpGet]
        public Task<List<EmlakIlanTipiResponse>> EmlakIlanTipi()
        {
            return _emlakIlanTipi.GetAllEmlakIlanTipiAsync();
        }
    }
}
