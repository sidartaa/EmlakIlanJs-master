using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{

    public class EmlakCepheController : ApiController
    {
        private readonly IEmlakCepheEngine _emlakCephe;
        public EmlakCepheController(IEmlakCepheEngine emlakCephe)
        {
            _emlakCephe = emlakCephe;
        }
        [HttpGet]
        public Task<List<EmlakCepheResponse>> EmlakCephe()
        {
            return _emlakCephe.GetAllEmlakCephesiAsync();
        }
    }
}
