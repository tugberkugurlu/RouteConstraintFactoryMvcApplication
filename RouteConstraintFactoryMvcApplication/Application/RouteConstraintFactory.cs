using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RouteConstraintFactoryMvcApplication.Application.RouteConstraint;
using RouteConstraintFactoryMvcApplication.Models;

namespace RouteConstraintFactoryMvcApplication.Application {

    public class RouteConstraintFactory : IRouteConstraintFactory {

        private readonly IDependencyResolver _dependencyResolver;

        public RouteConstraintFactory(IDependencyResolver dependencyResolver) {
            _dependencyResolver = dependencyResolver;
        }

        public System.Web.Routing.IRouteConstraint Create<TRouteConstraint>() where TRouteConstraint : System.Web.Routing.IRouteConstraint {

            return
                _dependencyResolver.GetService<TRouteConstraint>();
        }
    }
}