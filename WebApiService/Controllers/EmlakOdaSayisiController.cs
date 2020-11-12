using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{
    public class EmlakOdaSayisiController : ApiController
    {
        private readonly IEmlakOdaSayisiEngine _emlakOdaSayisi;
        public EmlakOdaSayisiController(IEmlakOdaSayisiEngine emlakOdaSayisi)
        {
            _emlakOdaSayisi = emlakOdaSayisi;
        }
        [HttpGet]
        public Task<List<EmlakOdaSayisiResponse>> EmlakOdaSayisi()
        {
            return _emlakOdaSayisi.GetAllEmlakOdaSayisiAsync();
        }
    }
}
