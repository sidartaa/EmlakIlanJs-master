using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using Ninject;
using System.Linq;

namespace WebApiService.ActionFilter.Logger
{
    public class CustomFilterProvider : IFilterProvider
    {
        public IEnumerable<FilterInfo> GetFilters(HttpConfiguration configuration, HttpActionDescriptor actionDescriptor)
        {
            List<FilterInfo> retval = new List<FilterInfo>();
            // IEnumerable<FilterInfo> actionFilter = actionDescriptor.GetFilters().Select(x=>new FilterInfo(x,FilterScope.Action));
            var actionFilter = actionDescriptor.GetFilters();
            var controllerFilter = actionDescriptor.ControllerDescriptor.GetFilters();
            Resolve(retval, controllerFilter, FilterScope.Controller);
            Resolve(retval, actionFilter, FilterScope.Action);
            return retval;
        }

        private void Resolve(List<FilterInfo> filters, Collection<IFilter> typedFilters, FilterScope scope)
        {
            foreach (var filter in typedFilters)
            {
                var instance = Ioc.Kernel.Get(filter.GetType());
                filters.Add(new FilterInfo((IFilter)instance,scope));
            }
        }
    }
}