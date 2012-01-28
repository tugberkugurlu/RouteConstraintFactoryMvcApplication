using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using RouteConstraintFactoryMvcApplication.Models;

namespace RouteConstraintFactoryMvcApplication.Application.RouteConstraint {

    public class UrlRouteConstraint : IUrlRouteConstraint {

        private readonly IUrlValidator _urlValidator;

        public UrlRouteConstraint(IUrlValidator urlValidator) {
            _urlValidator = urlValidator;
        }

        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection) {

            return _urlValidator.IsValid(values[parameterName].ToString());
        }
    }
}