using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RouteConstraintFactoryMvcApplication.Models {

    public class UrlValidator : IUrlValidator {

        public bool IsValid(string url) {

            return
                (url == "foo" || url == "bar");
        }
    }
}