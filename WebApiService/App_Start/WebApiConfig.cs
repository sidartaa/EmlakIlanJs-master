using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using WebApiService.Handlers;
using System.Web.Http.Dispatcher;
using WebApiService.Core;
using WebApiService.ActionFilter;
using TorbaliBurada.Controller;
using System.Web.Http.Filters;
using WebApiService.ActionFilter.Logger;
using Ninject;
namespace WebApiService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.MessageHandlers.Add(new ApiResponseHandler());
            //config.MessageHandlers.Add(new AuthenticationHandler());
            config.Services.Replace(typeof(IHttpControllerActivator), new WindsorHttpControllerActivator());
            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));
            
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
             name: "DefaultApi2",
             routeTemplate: "api/{controller}/{action}/{skip}/{take}",
             defaults: new { skip = RouteParameter.Optional, take = RouteParameter.Optional }
         );
            // Xml formatter'a gerek yok.
            var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);
        }
        //-----------------------------------------------------------------
        //public static void Register(HttpConfiguration config)
        //{
        //    // Web API configuration and services
        //    config.MessageHandlers.Add(new ApiResponseHandler());
        //    //Artık, Api’lerimize gelecek istekler öncelikle bu handler’ı doğru credential bilgileriyle aşmak durumundadır.. 
        //    //Eğer istersek kullanıcı bilgilerine Api içerisindende erişebileceğiz
        //    config.MessageHandlers.Add(new AuthenticationHandler());
        //    config.Services.Replace(typeof(IHttpControllerActivator), new WindsorHttpControllerActivator());
        //    config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        //    config.SuppressDefaultHostAuthentication();
        //    config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));
        //    //Custom Filter
        //    //config.Filters.Add(new LoggerFilter());
        //    config.Services.Remove(typeof(IFilterProvider),config.Services.GetFilterProviders().Single(x => x is ActionDescriptorFilterProvider));
        //    config.Services.Add(typeof(IFilterProvider), Ioc.Kernel.Get<IFilterProvider>());
        //    // Web API routes
        //    config.MapHttpAttributeRoutes();

        //    config.Routes.MapHttpRoute(
        //        name: "DefaultApi",
        //        routeTemplate: "api/{controller}/{action}/{id}",
        //        defaults: new { id = RouteParameter.Optional }
        //    );
        //    config.Routes.MapHttpRoute(
        //     name: "DefaultApi2",
        //     routeTemplate: "api/{controller}/{action}/{skip}/{take}",
        //     defaults: new { skip = RouteParameter.Optional, take = RouteParameter.Optional }
        // );

        //}
        //-------------------------------------------------------------
        //public static void Register(HttpConfiguration config)
        //{
        //    // Web API configuration and services
        //    // Configure Web API to use only bearer token authentication.
        //    config.SuppressDefaultHostAuthentication();
        //    config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

        //    // Web API routes
        //    config.MapHttpAttributeRoutes();

        //    config.Routes.MapHttpRoute(
        //        name: "DefaultApi",
        //        routeTemplate: "api/{controller}/{id}",
        //        defaults: new { id = RouteParameter.Optional }
        //    );
        //}
    }
}
