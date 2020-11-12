using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{
    public class EmlakTapuDurumuController : ApiController
    {
        private readonly IEmlakTapuDurumuEngine _emlakTapuDurumu;
        public EmlakTapuDurumuController(IEmlakTapuDurumuEngine emlakTapuDurumu)
        {
            _emlakTapuDurumu = emlakTapuDurumu;
        }

        [HttpGet]
        public Task<List<EmlakTapuDurumuResponse>> EmlakTapuDurumu()
        {
            return _emlakTapuDurumu.GetAllEmlkaTapuDurumumAsync();
        }
    }
}
