using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using TorbaliBurada.Core;
using Castle.DynamicProxy;
using System.Web.Http.Controllers;
using Torbali.Core.Common.Contracts;
using TorbaliBurada.Data.Contracts;
using System.Data.Entity;
using TorbaliBurada.Business;
using TorbaliBurada.Data.CodeFirst.Entity;

namespace WebApiService.Core
{
    public class WindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            RegisterInterceptors(container);

            RegisterHttpControllers(container);

            RegisterConfigurationHelpers(container);

            RegisterEngines(container);

            RegisterEntityFrameworkContexts(container);
         
            RegisterDataRepositories(container);

            RegisterCacheProviders(container);

            RegisterLoggers(container);

            RegisterBussenis(container);

            RegisterBussinesEngine(container);
            
            //throw new NotImplementedException();
        }

       

        private void RegisterBussinesEngine(IWindsorContainer container)
        {
            container.Register(
                DependencyContainer.Descriptor.BasedOn<BusinessEngineBase>().WithServiceBase().LifestyleSingleton()
                );
        }

        private void RegisterBussenis(IWindsorContainer container)
        {
            container.Register(
               DependencyContainer.Descriptor
               .BasedOn<Torbali.Core.Common.Contracts.IBusinessEngine>()
               .WithServiceBase()
               .LifestyleSingleton()
               );
        }

        private void RegisterLoggers(IWindsorContainer container)
        {
            container.Register(
                DependencyContainer.Descriptor
                .BasedOn<Torbali.Core.Common.Contracts.ILogger>()
                .WithServiceBase()
                .LifestyleSingleton()
                );
        }

        private void RegisterCacheProviders(IWindsorContainer container)
        {
            container.Register(
                DependencyContainer.Descriptor
                .BasedOn<ICacheProvider>()
                .WithServiceBase()
                .LifestyleSingleton()
                );
        }

        private static void RegisterDataRepositories(IWindsorContainer container)
        {
            container.Register(
                DependencyContainer.Descriptor
                .BasedOn(typeof(IRepositoryBase<,>))
                .WithService
                .AllInterfaces()
                .LifestylePerWebRequest()
                );
        }

        private static void RegisterEntityFrameworkContexts(IWindsorContainer container)
        {
            container.Register(Component.For<DbContext>()
                .ImplementedBy<TorbaliBuradaCodeModel>()
                .LifestylePerWebRequest()
                );
        }

        private void RegisterEngines(IWindsorContainer container)
        {
            container.Register(
                DependencyContainer.Descriptor
                .BasedOn<IBusinessEngine>()
                .WithService
                .AllInterfaces()
                .LifestylePerWebRequest()
                );
        }

        private void RegisterConfigurationHelpers(IWindsorContainer container)
        {
            container.Register(
                DependencyContainer.Descriptor
                .BasedOn<IConfigurationHelper>()
                .WithServiceBase()
                .LifestyleSingleton()
                );
        }

        private void RegisterHttpControllers(IWindsorContainer container)
        {
            container.Register(
                DependencyContainer.Descriptor
                .BasedOn<IHttpController>()
                .WithService
                .Self()
                .LifestylePerWebRequest()
                );
        }

        private void RegisterInterceptors(IWindsorContainer container)
        {
            container.Register(
                DependencyContainer.Descriptor
                .BasedOn<IInterceptor>()
                .WithService
                .Self()
                .LifestylePerWebRequest()
                );
        }
    }
}