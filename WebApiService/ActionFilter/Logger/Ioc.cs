using Ninject;
using System.Reflection;
using System.Web.Http.Filters;


namespace WebApiService.ActionFilter.Logger
{
    public static class Ioc
    {
        public static IKernel _kernel = null;

        public static IKernel Kernel
        {
            get
            {
                if (_kernel == null)
                {
                    InitalizeKarnel();
                }
                return _kernel;
            }
        }
        private static void InitalizeKarnel()
        {
            _kernel = new StandardKernel();
            _kernel .Load(Assembly.GetExecutingAssembly());
            _kernel.Bind<ILoggerr>()
                .To<OutputScreenLogger>()
                .InSingletonScope();
            _kernel
                .Bind<IFilterProvider>()
                .To<CustomFilterProvider>()
                .InSingletonScope();
            _kernel
                .Bind<LoggerFilter>()
                .To<LoggerFilter>()
                .InSingletonScope();
        }
    }
}