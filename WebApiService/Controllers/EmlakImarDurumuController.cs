using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{
    public class EmlakImarDurumuController : ApiController
    {
        private readonly IEmlakImarDurumuEngine _emlakImarDurumu;
        public EmlakImarDurumuController(IEmlakImarDurumuEngine emlakImarDurumu)
        {
            _emlakImarDurumu = emlakImarDurumu;
        }
        [HttpGet]
        public Task<List<EmlakImarDurumuResponse>> EmlakImarDurumu()
        {
            return _emlakImarDurumu.GetAllEmlakImarAsync();
        }
    }
}
