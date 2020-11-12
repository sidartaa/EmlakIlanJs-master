using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{
    public class EmlakKullanimDurumuController : ApiController
    {
        private readonly IEmlakKullanimDurumuEngine _emlakKullanimDurumu;
        public EmlakKullanimDurumuController(IEmlakKullanimDurumuEngine emlakKullanimDurumu)
        {
            _emlakKullanimDurumu = emlakKullanimDurumu;
        }
        [HttpGet]
        public Task<List<EmlakKullanimDurumuResponse>> EmlakKullanimDurumu()
        {
            return _emlakKullanimDurumu.GetAllEmlakKullanimDurumuAsync();
        }
    }
}
