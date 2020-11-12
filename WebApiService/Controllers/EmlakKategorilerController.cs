using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{
    public class EmlakKategorilerController : ApiController
    {
        private readonly IEmlakKategorilerEngine _emlakKategoriler;
        public EmlakKategorilerController(IEmlakKategorilerEngine emlakKategorile)
        {
            _emlakKategoriler = emlakKategorile;
        }
        [HttpGet]
        public Task<List<EmlakKategoilerResponse>> EmlakKategoriler()
        {
            return _emlakKategoriler.GetAllEmlakKategorilerAsync();
        }
        [HttpGet]
        public Task<List<EmlakKategoilerResponse>> GetEmlakKategori(int id)
        {
            return _emlakKategoriler.GetParentIdKategorilerAsync(id);
        }
    }
}
