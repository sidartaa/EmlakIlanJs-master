using System;
using System.Diagnostics;
using System.Web.Http.Filters;

namespace WebApiService.ActionFilter
{
    public class ÊxceptionHandler : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            var actionDescriptor = actionExecutedContext.ActionContext.ActionDescriptor;
            string message = string.Join("-", "An Error", actionDescriptor.ControllerDescriptor.ControllerName,
                actionDescriptor.ActionName, actionExecutedContext.Exception.Message);
            Debug.WriteLine(message);
            //loglama yap...

            actionExecutedContext.Response.Headers.Add("ErrorID", Guid.NewGuid().ToString());
            base.OnException(actionExecutedContext);
        }
    }
}