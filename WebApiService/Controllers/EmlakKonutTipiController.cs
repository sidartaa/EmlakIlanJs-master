using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{
    public class EmlakKonutTipiController : ApiController
    {
        private readonly IEmlakKonutTipiEngine _emlakKonutTipi;
        public EmlakKonutTipiController(IEmlakKonutTipiEngine emlakKonutTipi)
        {
            _emlakKonutTipi = emlakKonutTipi;
        }
        [HttpGet]
        public Task<List<EmlakKonutTipiResponse>> EmlakKonutTipi()
        {
            return _emlakKonutTipi.GetAllEmlakKonutTipiSayisiAsync();
        }
    }
}
