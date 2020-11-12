using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{
    public class EmlakKimdenController : ApiController
    {
        private readonly IEmlakKimdenEngine _emlakKimden;
        public EmlakKimdenController(IEmlakKimdenEngine emlakKimden)
        {
            _emlakKimden = emlakKimden;
        }
       
        [HttpGet]
        public Task<List<EmlakKimdenResponse>> EmlakKimden()
        {
            return _emlakKimden.GetAllEmlakKimdenAsync();
        }
    }
}
