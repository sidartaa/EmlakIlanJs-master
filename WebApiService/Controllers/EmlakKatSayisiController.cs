using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{
    public class EmlakKatSayisiController : ApiController
    {
        private readonly IEmlakKatSayisiEngine _emlakKatSayisi;
        public EmlakKatSayisiController(IEmlakKatSayisiEngine emlakKatSayisi)
        {
            _emlakKatSayisi = emlakKatSayisi;
        }
        [HttpGet]
        public Task<List<EmlakKatSayisiResponse>> EmlakKatSayisi()
        {
            return _emlakKatSayisi.GetAllEmlakKatSayisiAsync();
        }
    }
}
