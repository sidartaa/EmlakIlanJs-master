using nQuant;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Torbali.Core.Common.Contracts.RequestMessages;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts;
using TorbaliBurada.Controller;

namespace TorbaliBurada.ServiceHost.Api.Controllers
{

    public class BinaYasiController : ApiController
    {
        private readonly IEmlakBinaYasiEngine _emlakBinaYasiEngine;
        public BinaYasiController(IEmlakBinaYasiEngine emlakBinaYasiEngine)
        {
            _emlakBinaYasiEngine = emlakBinaYasiEngine;
        }
        [HttpGet]
        public HttpResponseMessage Resize(string source, int width, int height)
        {
            var sourceExtension = Path.GetExtension(source);

            var httpResponseMessage = new HttpResponseMessage();

            Image image = Image.FromFile(HttpContext.Current.Server.MapPath(source));

            Image resizedImage = PhotoFileHelper.Resize(image, width, height);

            var memoryStream = new MemoryStream();

            var quantizer = new WuQuantizer();

            using (var bitmap = new Bitmap(resizedImage))
            {
                using (var quantized = quantizer.QuantizeImage(bitmap, 1, 1))
                {
                    quantized.Save(memoryStream, PhotoFileHelper.GetImageFormat(sourceExtension));
                }
            }

            httpResponseMessage.Content = new ByteArrayContent(memoryStream.ToArray());

            httpResponseMessage.Content.Headers.ContentType = PhotoFileHelper.GetMediaContentType(sourceExtension);

            httpResponseMessage.StatusCode = HttpStatusCode.OK;

            return httpResponseMessage;
        }
        public HttpResponseMessage Hata()
        {
            int.Parse("Bir hata istiyoruz");
            return Request.CreateResponse(HttpStatusCode.OK);
        }
       // [LoggerFilter]
        public Task<EmlakBinaYasiResponse> Get(int id)
        { 
            return _emlakBinaYasiEngine.GetAsync(id);
        }
        public Task<List<EmlakBinaYasiResponse>> Get(int skip, int take)
        {
            return _emlakBinaYasiEngine.GetAllAsync(skip, take);
        }
        [Authorize]
        public Task<EmlakBinaYasiResponse> Put([FromBody] BinaYasiUpdateRequest request)
        {
            return _emlakBinaYasiEngine.UpdateAsync(request);
        }
        [Authorize]
        public Task<EmlakBinaYasiResponse> Posta([FromBody] BinaYasiRequest request)
        {
            return _emlakBinaYasiEngine.CreateAsync(request);
        }
        [Authorize]
        public Task Delete(int id)
        {
            return _emlakBinaYasiEngine.DeleteAsync(id);
        }
        [HttpGet]
        public Task<List<EmlakBinaYasiResponse>> Search([FromUri]BinaYasiSearchRequest request)
        {
            return _emlakBinaYasiEngine.SearchAsync(request);
        }


    }
}
