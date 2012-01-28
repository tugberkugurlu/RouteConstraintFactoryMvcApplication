using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RouteConstraintFactoryMvcApplication.Models;

namespace RouteConstraintFactoryMvcApplication.Test.Fakes {

    public class FakeUrlValidator : IUrlValidator {

        public bool IsValid(string url) {

            return
                (url == "foo");
        }
    }
}
