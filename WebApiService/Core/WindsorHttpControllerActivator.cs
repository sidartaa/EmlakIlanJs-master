using System;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using TorbaliBurada.Core;

namespace WebApiService.Core
{
    public class WindsorHttpControllerActivator : IHttpControllerActivator
    {
        public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            var instance = DependencyContainer.Resolve(controllerType);
            if (instance == null)
            {
                throw new HttpException((int)HttpStatusCode.NotFound, string.Format("{0}, cannot be resolve", controllerType.Name));
            }
            return (IHttpController)instance;
        }
    }
}