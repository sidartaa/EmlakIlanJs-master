using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Torbali.Core.Common.Contracts.RequestMessages.IlanResimler;
using Torbali.Core.Common.Contracts.ResponseMessages;
using TorbaliBurada.Business.Contracts.IEmlakEngine;
using WebApiService.Helpers;
using WebApiService.Models;

namespace WebApiService.Controllers
{
    [RoutePrefix("api/Upload")]
    public class UploadController : ApiController
    {
        private readonly IIlanResimlerEngine _ilanResimlerEngine;
        public UploadController(IIlanResimlerEngine ilanResimlerEngine)
        {
            _ilanResimlerEngine = ilanResimlerEngine;
        }

        [Route("GetImages")]
        [HttpGet]
        public Task<List<IlanResimlerResponse>> GetImages([FromUri]IlanResimlerRequeste request)
        {
            bool x = FunctionHelper.IsValid(Convert.ToString(request.IlanId));
            if (x == true)
            {
                request.IlanId = Convert.ToInt32(request.IlanId);
               // request.Resim = FunctionHelper.RemoveHtml(request.Resim);  
                return _ilanResimlerEngine.GetListResimAsync(request);
            }
            else
                return null;

        }
        [Authorize]
        [Route("DeleteImages")]
        [HttpGet]
        public Task DeleteImages([FromUri]IlanResimlerRequeste request)
        {
            
            bool y = FunctionHelper.IsValid(Convert.ToString(request.id));
            if (y==true)
            {
                request.id= Convert.ToInt32(request.id);
            }
            return _ilanResimlerEngine.DeleteAsync(request.id);
            //else
            //    return false;


        }
        [Authorize]
        [Route("user/UserImage")]
        public async Task<IlanResimlerResponse> Post()
        {
           // Dictionary<string, object> dict = new Dictionary<string, object>();
            IlanResimlerRequest request = new IlanResimlerRequest();
            var httpRequest = HttpContext.Current.Request;
            try
            {
                if (!Request.Content.IsMimeMultipartContent())
                {
                    throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
                }

                //Save To this server location
                var uploadPath = HttpContext.Current.Server.MapPath("~/Userimage");
                //The reason we not use the default MultipartFormDataStreamProvider is because
                //the saved file name is look weird, not believe me? uncomment below and try out, 
                //the odd file name is designed for security reason -_-'.
                //var streamProvider = new MultipartFormDataStreamProvider(uploadPath);

                //Save file via CustomUploadMultipartFormProvider
                var multipartFormDataStreamProvider = new CustomUploadMultipartFormProvider(uploadPath);
                FileResult fl = new FileResult()
                {
                    FileNames = multipartFormDataStreamProvider.FileData.Select(entry => entry.LocalFileName),
                    Names = multipartFormDataStreamProvider.FileData.Select(entry => entry.Headers.ContentDisposition.FileName),
                    ContentTypes = multipartFormDataStreamProvider.FileData.Select(entry => entry.Headers.ContentType.MediaType),
                    Description = multipartFormDataStreamProvider.FormData["description"],
                    CreatedTimestamp = DateTime.UtcNow,
                    UpdatedTimestamp = DateTime.UtcNow,
                    DownloadLink = "TODO, will implement when file is persisited"
                };
                // Read the MIME multipart asynchronously 
                await Request.Content.ReadAsMultipartAsync(multipartFormDataStreamProvider);

                // Show all the key-value pairs.
                foreach (var key in multipartFormDataStreamProvider.FormData.AllKeys)
                {
                    foreach (var val in multipartFormDataStreamProvider.FormData.GetValues(key))
                    {
                        if (key == "id")
                            request.IlanId = Convert.ToInt32(val);
                       // Debug.WriteLine(string.Format("{0}: {1}", key, val));
                    }
                }
                List<string> list = new List<string>();
                foreach (MultipartFileData file in multipartFormDataStreamProvider.FileData)
                {
                    string fileName = file.Headers.ContentDisposition.FileName;
                    if (fileName.StartsWith("\"") && fileName.EndsWith("\""))
                    {
                        fileName = fileName.Trim('"');
                        ImagesProses.ResimBoyutlandir(fileName,1200,800);
                    }
                    
                    list.Add(fileName);
                    
                }

                //In Case you want to get the files name
                //string localFileName = multipartFormDataStreamProvider
                //    .FileData.Select(multiPartData => multiPartData.LocalFileName).FirstOrDefault();
                //IlanResimlerRequest request2 = new IlanResimlerRequest();
                //foreach (var item in request.Resimler)
                //{
                //    request2.IlanId = request.IlanId;
                //    request2.Resim = item;
                //    return _ilanResimlerEngine.CreateAsync(request2);

                //}
                request.Resimler = list;
                return await _ilanResimlerEngine.CreateAsync(request);
                // return new  HttpResponseMessage(HttpStatusCode.OK);




            }
            catch (Exception e)
            {
                new HttpResponseMessage(HttpStatusCode.NotImplemented)
                {
                    Content = new StringContent(e.Message)
                };
                return null;
            }





        }
    }
}
