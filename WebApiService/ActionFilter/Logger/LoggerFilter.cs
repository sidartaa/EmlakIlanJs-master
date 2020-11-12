using Ninject;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;


namespace WebApiService.ActionFilter.Logger
{
  //  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]  
    public class LoggerFilter: ActionFilterAttribute
    {
        [Inject]
        public ILoggerr _logger { get; set; }
       
        public override void OnActionExecuting(HttpActionContext actionContext)
                    {
            _logger.Log(string.Format("{0} is invorking",actionContext.ActionDescriptor.ActionName));
            base.OnActionExecuting(actionContext);
        }
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            _logger.Log(string.Format("{0} is invorked", actionExecutedContext.ActionContext.ActionDescriptor.ActionName));
            base.OnActionExecuted(actionExecutedContext);
        }


    }
}