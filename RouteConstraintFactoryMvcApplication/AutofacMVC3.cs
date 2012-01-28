using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using RouteConstraintFactoryMvcApplication.Application.RouteConstraint;
using RouteConstraintFactoryMvcApplication.Models;

namespace RouteConstraintFactoryMvcApplication {

    public class AutofacMVC3 {

        public static void Initialize() {

            var builder = new ContainerBuilder();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(RegisterServices(builder)));
        }

        private static IContainer RegisterServices(ContainerBuilder builder) {

            builder.RegisterControllers(typeof(MvcApplication).Assembly).PropertiesAutowired();

            builder.RegisterType<UrlValidator>().As<IUrlValidator>();
            builder.Register(c => new UrlRouteConstraint(c.Resolve<IUrlValidator>())).As<IUrlRouteConstraint>();

            return
                builder.Build();
        }
    }
}