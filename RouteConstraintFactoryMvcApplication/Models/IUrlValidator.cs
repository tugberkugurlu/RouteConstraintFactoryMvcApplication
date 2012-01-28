using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RouteConstraintFactoryMvcApplication.Models
{
    public interface IUrlValidator {

        bool IsValid(string url);
    }
}