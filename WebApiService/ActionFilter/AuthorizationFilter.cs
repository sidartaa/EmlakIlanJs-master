using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebApiService.ActionFilter
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorizationFilter : Attribute, IAuthorizationFilter
    {
        public bool AllowMultiple
        {
            get
            {
                return false;
            }
        }

        public Task<HttpResponseMessage> ExecuteAuthorizationFilterAsync(HttpActionContext actionContext, CancellationToken cancellationToken, Func<Task<HttpResponseMessage>> continuation)
        {
            var principal = actionContext.ControllerContext.RequestContext.Principal;
            if (principal != null && principal.Identity.IsAuthenticated)
            {
                //Hiç bir şey yapma akışa devam et... return sil yeter..
                return continuation.Invoke();
            }
            else
            {
                var response = actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Giriş yapınız..");
                return Task.FromResult(response);
            }

        }
    }
}