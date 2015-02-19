using System;
using System.Web;
using System.Web.Mvc;

namespace BootstrapTable.Web
{
    public class FilterConfig
    {
        [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
        public class ViewBagDefaults : ActionFilterAttribute
        {
            public override void OnResultExecuting(ResultExecutingContext filterContext)
            {
                filterContext.Controller.ViewBag.Package = "bootstrap-table.mvc";
                filterContext.Controller.ViewBag.Repository = "simonray/bootstrap-table.mvc";
            }
        }

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ViewBagDefaults());
        }
    }
}
