using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using RouteConstraintFactoryMvcApplication.Application;

namespace RouteConstraintFactoryMvcApplication
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication {

        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {

            filters.Add(new HandleErrorAttribute());
        }

        protected void Application_Start() {

            AutofacMVC3.Initialize();

            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            IRouteRegistry routeRegisterer = new MyRouteRegistry(new RouteConstraintFactory(DependencyResolver.Current));
            routeRegisterer.RegisterRoutes(RouteTable.Routes);
        }
    }
}