using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{
    public class EmlakTakasliController : ApiController
    {
        private readonly IEmlakTakasliEngine _emlakTakasli;
        public EmlakTakasliController(IEmlakTakasliEngine emlakTakasli)
        {
            _emlakTakasli = emlakTakasli;
        }
        [HttpGet]
        public Task<List<EmlakTakasliResponse>> EmlakTakasli()
        {
            return _emlakTakasli.GetAllEmlakTakaslieAsync();
        }
    }
}
