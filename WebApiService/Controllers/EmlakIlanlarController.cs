using System.Threading.Tasks;
using System.Web.Helpers;
using System.Web.Http;
using Torbali.Core.Common.Contracts.RequestMessages.Ilanlar;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{
    //[RoutePrefix("api/Search")]
    [Authorize]
    public class EmlakIlanlarController : ApiController
    {
        private readonly IIlanlarIlanEngine _ilanIlanlarEngine;
        public EmlakIlanlarController(IIlanlarIlanEngine ilanIlanlarEngine)
        {
            _ilanIlanlarEngine = ilanIlanlarEngine;
        }
      
       [HttpPost]
        public Task<IlanIlanlarResponse> IlanEkle([FromBody] EmlakIlanRequest request)
        {
            string cookieToken;
            string formToken;
            AntiForgery.GetTokens(null, out cookieToken, out formToken);
           var cookieTokenv = cookieToken;
           var formTokenn = formToken;
           // string[] temp = request["Konular.KategoriID"].Split(',');
            return _ilanIlanlarEngine.CreateAsync(request);
        }

       
    }
}
