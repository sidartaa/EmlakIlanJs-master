using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebApiService.ActionFilter
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class HomeActionFilter :Attribute, IActionFilter
    {
        public bool AllowMultiple
        {
            get
            {
                return false;
            }
        }

        public Task<HttpResponseMessage> ExecuteActionFilterAsync(HttpActionContext actionContext, CancellationToken cancellationToken, Func<Task<HttpResponseMessage>> continuation)
        {
            // ExecuteActionFilterAsync:Filter tetiklendiğinde continuation parametresi ile gelen invoke metodu tetiklenir.
            Debug.WriteLine(string.Format("{0} is Invoking",actionContext.ActionDescriptor.ActionName));
            var result= continuation.Invoke();
            Debug.WriteLine(string.Format("{0} is Invoked", actionContext.ActionDescriptor.ActionName));
            return result;
        }
    }
}