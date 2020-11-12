using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{
    public class EmlakKullanimAmaciController : ApiController
    {
        private readonly IEmlakKullanimAmaciEngine _emlakKullanimAmaci;
        public EmlakKullanimAmaciController(IEmlakKullanimAmaciEngine emlakKullanimAmaci)
        {
            _emlakKullanimAmaci = emlakKullanimAmaci;
        }
        [HttpGet]
        public Task<List<EmlakKullanimAmaciResponse>> EmlakKullanimAmaci()
        {
            return _emlakKullanimAmaci.GetAllEmlakKullanimAmaciAsync();
        }
    }
}
