using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;

namespace WebApiService.Controllers
{
    public class EmlakLocationController : ApiController
    {
        private readonly IEmlakLocationEngine _emlakLocation;
        public EmlakLocationController(IEmlakLocationEngine emlakLocation)
        {
            _emlakLocation = emlakLocation;
        }
        [HttpGet]
        public Task<List<EmlakLocationResponse>> EmlakLocation()
        {
            return _emlakLocation.GetAllEmlakLocationAsync();
        }

        [HttpGet]
        public Task<List<EmlakLocationCheckResponse>> GetEmlakLocation(int id)
        {
            return _emlakLocation.GetEmlakLocationAsync(id);
        }

    }
}
