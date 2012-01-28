using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace RouteConstraintFactoryMvcApplication.Application {

    public interface IRouteConstraintFactory {

        IRouteConstraint Create<TRouteConstraint>()
            where TRouteConstraint : IRouteConstraint;
    }
}