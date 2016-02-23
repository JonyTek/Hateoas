using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Hateoas.Web.Builders;
using Hateoas.Web.Models;

namespace Hateoas.Web.Controllers
{
    [RoutePrefix("api/product")]
    public class ProductController : ApiController
    {
        [Route]
        public Product Get()
        {
            var gotProduct =  new Product();
            var builder = new ProductResourcesBuilder();
            builder.Build(new User(), gotProduct);
        }

    }
}
