using Ecommerce_asp.netWebApp.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce_asp.netWebApp.Entity
{
    public class IdentityDataContext:IdentityDbContext<ApplicationUser>
    {
        public IdentityDataContext():base("dataConnection")
        {

        }
    }
}