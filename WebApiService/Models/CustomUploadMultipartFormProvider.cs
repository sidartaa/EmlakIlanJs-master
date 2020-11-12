using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace WebApiService.Models
{
    public class CustomUploadMultipartFormProvider : MultipartFormDataStreamProvider
    {
        public CustomUploadMultipartFormProvider(string rootPath) : base(rootPath)
        {
        }
        public override string GetLocalFileName(HttpContentHeaders headers)
        {
            if (headers != null && headers.ContentDisposition != null)
            {
                return headers
                   .ContentDisposition
                   .FileName.TrimEnd('"').TrimStart('"').Replace('ş', 's').Replace('Ş', 'S').Replace('ç', 'c').Replace("Ç", "C").Replace('ğ', 'g').Replace('Ğ', 'G').Replace('ü', 'u').Replace('Ü', 'U').Replace('ı', 'i').Replace('İ', 'I').Replace('ö', 'o').Replace('Ö', 'O').Replace(' ', '-').Replace("?", "").Replace(",", "").Replace("/", "").Replace("\"", "").Replace("\'", "").Replace(":", "-").Replace("&", "-").Replace("*", "").Replace("%", "").Replace("!", "-");
            }

            return base.GetLocalFileName(headers);
        }
    }
}