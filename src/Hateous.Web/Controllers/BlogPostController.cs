using System;
using System.Web.Http;
using Hateous.Core.Enrichers;
using Hateous.Core.Model;
using Hateous.Core.Services;

namespace Hateous.Web.Controllers
{
    [RoutePrefix("api/blog")]
    public class BlogPostController : ApiController
    {


        private readonly IBlogPostService blogPostService;

        private readonly IEnrichDomain<BlogPost> enricher;

        private readonly IUserService userService;

        public BlogPostController(IBlogPostService blogPostService, IUserService userService,
            IEnrichDomain<BlogPost> enricher)
        {
            this.blogPostService = blogPostService;
            this.userService = userService;
            this.enricher = enricher;
        }

        [HttpGet]
        [Route("posts")]
        public BlogPost Get()
        {
            var t = this;
            var post = blogPostService.Retrieve(Guid.Empty);
            var user = userService.Retrieve(new Guid());

            return enricher.Enrich(user, post);
        }
    }
}