using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.RequestMessages.Musteriler;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts.IEmlakEngine;

namespace WebApiService.Controllers
{
    public class MusteriListController : ApiController
    {
        private readonly IMusteriListEngine _musteriList;
        public MusteriListController(IMusteriListEngine musteriList)
        {
            _musteriList = musteriList;
        }

        [Authorize]
        [HttpPost]
        public Task<MusterilerResponse> MusteriEkle([FromBody] MusterilerListInsertRequest request)
        {
            return _musteriList.CreateAsync(request);
        }

        [Authorize]
        [HttpGet]
        public Task<MusterilerListResponse> MusteriListesi([FromUri]SerchMusteriRequest request)
        {
            return _musteriList.GetAllMusterilerAsync(request);
        }
    }
}
