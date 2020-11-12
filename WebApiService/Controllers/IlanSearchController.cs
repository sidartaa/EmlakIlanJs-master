using MvcThrottle;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Torbali.Core.Common.Contracts.RequestMessages.IlanEmlakGenel;
using Torbali.Core.Common.Contracts.RequestMessages.Ilanlar;
using Torbali.Core.Common.Contracts.RequestMessages.IlanResimler;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Business.Contracts.IEmlakEngine;
using TorbaliBurada.Entity.Contracts;
using WebApiService.Models;

namespace WebApiService.Controllers
{
    [RoutePrefix("api/Search")]  
    public class IlanSearchController : ApiController
    {
        private readonly IIlanlarIlanEngine _ilanIlanlarEngine;
        private readonly IIlanResimlerEngine _ilanResimler;
        private readonly IIlanlarEmlakGenelEngine _ilanEmlakGenel;
        public IlanSearchController(IIlanlarIlanEngine ilanIlanlarEngine, IIlanResimlerEngine ilanResimler, IIlanlarEmlakGenelEngine ilanEmlakGenel)
        {
            _ilanIlanlarEngine = ilanIlanlarEngine;
            _ilanResimler = ilanResimler;
            _ilanEmlakGenel = ilanEmlakGenel;
        }
        //
        [Route("Recaptcha")]
        [HttpPost]
        public bool Validate([FromBody]RecaptchaRequest request)
        {
            if (string.IsNullOrEmpty(request.Response)) return false;

            var secret = "6Lf_riMUAAAAAMSczpv9Ll0DZVynuoKVCDbl3Jvs";
            if (string.IsNullOrEmpty(secret)) return false;

            var client = new System.Net.WebClient();

            var googleReply = client.DownloadString(
                $"https://www.google.com/recaptcha/api/siteverify?secret={secret}&response={request.Response}&remoteip={request.RemoteIp}");

            return JsonConvert.DeserializeObject<RecaptchaResponse>(googleReply).Success;
        }
        [Route("Default")]
        [HttpGet]        
        public Task<List<IlanResponse>> Search([FromUri]SerchRequest request)
        {
                    
            return _ilanIlanlarEngine.SearchAsync(request);
        }
        [Route("DefaultS")]
        [HttpGet]
        [EnableThrottling(PerSecond = 2, PerMinute = 10, PerHour = 30, PerDay = 300)]
        public Task<TotalPageSearchResponse> SearchTotalPage([FromUri]SerchRequest request)
        {  
            return _ilanIlanlarEngine.TotalPageAsync(request);
             // _ilanIlanlarEngine.SearchTotalPageAsync(request);
             //return new JsonResult { Data = new { List = list, currentPage = page, totalPage = totalPage }, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        [Route("Default/Emlak")]
        [HttpGet]
        public Task<TotalPageSearchResponse> EmlakSearch([FromUri]SerchRequest request)
        {
            return _ilanIlanlarEngine.SearchTotalPageEmlakAsync(request);
        }
        [Route("Default/Images")]
        [HttpGet]
        public Task<IlanResimlerResponse> ImageSearch([FromUri]IlanResimlerRequeste request)
        {
            return _ilanResimler.GetResimAsync(request);
        }
       
        [Route("Default/IlanDetay")]
        [HttpGet]
        public Task<IlanEmlakGenelResponse> IlanDetay([FromUri]IlanEmlakGenelRequest request)
        {
            return _ilanEmlakGenel.GetAsync(request);
        }
       
        [Route("Default/UpdateIlan")]
        [Authorize]
        [HttpPost]
        public Task<IlanUpdateResponse> UpdateIlan([FromBody]UpdateIlanRequest request)
        {
            return _ilanIlanlarEngine.UpdateAsync(request);
        }
        
        [Route("Default/GetIlan")]
        [Authorize]
        [HttpGet]
        public Task<IlanIlanlarResponse> Ilan(int id)
        {
            return _ilanIlanlarEngine.GetAsync(id);
        }
    }
}
