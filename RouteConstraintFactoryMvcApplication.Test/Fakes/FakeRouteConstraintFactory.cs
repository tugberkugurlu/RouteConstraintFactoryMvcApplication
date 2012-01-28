using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RouteConstraintFactoryMvcApplication.Application;

namespace RouteConstraintFactoryMvcApplication.Test.Fakes {

    public class FakeRouteConstraintFactory : IRouteConstraintFactory {

        public System.Web.Routing.IRouteConstraint Create<TRouteConstraint>() where TRouteConstraint : System.Web.Routing.IRouteConstraint {

            return
                new RouteConstraintFactoryMvcApplication.Application.RouteConstraint.UrlRouteConstraint(new FakeUrlValidator());
        }
    }
}
