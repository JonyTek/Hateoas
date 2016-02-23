using System;
using System.Web.Http;
using Hateous.Core.Enrichers;
using Hateous.Core.Model;
using Hateous.Core.Services;

namespace Hateous.Web.Controllers
{
    [RoutePrefix("blog")]
    public class BlogPostController : ApiController
    {
        private readonly IBlogPostService blogPostService;

        private readonly IUserService userService;

        private readonly IEnrichDomain<BlogPost> enricher;

        public BlogPostController(IBlogPostService blogPostService, IUserService userService, IEnrichDomain<BlogPost> enricher)
        {
            this.blogPostService = blogPostService;
            this.userService = userService;
            this.enricher = enricher;
        }

        [Route("posts/{id}")]
        public BlogPost Get(Guid id)
        {
            var post = blogPostService.Retrieve(id);
            var user = userService.Retrieve(new Guid());
           
            return enricher.Enrich(user, post);
        }
    }

    

    
}
