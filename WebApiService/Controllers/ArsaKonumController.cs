using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{
    public class ArsaKonumController : ApiController
    {
        private readonly IArsaKonumEngine _arsaKonum;
        public ArsaKonumController(IArsaKonumEngine arsaKonum)
        {
            _arsaKonum = arsaKonum;
        }
        [HttpGet]
        public Task<List<ArsaKonumuResponse>> ArsaKonumu()
        {
            return _arsaKonum.GetAllArsaKonumiAsync();
        }
    }
}
