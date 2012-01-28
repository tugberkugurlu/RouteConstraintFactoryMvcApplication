using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using RouteConstraintFactoryMvcApplication.Application;
using RouteConstraintFactoryMvcApplication.Application.RouteConstraint;

namespace RouteConstraintFactoryMvcApplication {

    public interface IRouteRegistry {

        void RegisterRoutes(RouteCollection routes);
    }

    public class MyRouteRegistry : IRouteRegistry {

        private readonly IRouteConstraintFactory routeConstraintFactory;

        public MyRouteRegistry(IRouteConstraintFactory routeConstraintFactory) {

            this.routeConstraintFactory = routeConstraintFactory;
        }

        public void RegisterRoutes(RouteCollection routes) {

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "DefaultOne", // Route name
                "Home/{url}", // URL with parameters
                new { controller = "Home", action = "FooBar" }, // Parameter defaults
                new { url = routeConstraintFactory.Create<IUrlRouteConstraint>() }
            );

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Default", action = "Foo", id = UrlParameter.Optional } // Parameter defaults
            );
        }
    }
}