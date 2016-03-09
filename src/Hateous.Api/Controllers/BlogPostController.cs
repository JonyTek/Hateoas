using System;
using System.Web.Http;
using Hateous.Core.Enrichers;
using Hateous.Core.Model;
using Hateous.Core.Services;

namespace Hateous.Api.Controllers
{
    [RoutePrefix("api/blog")]
    public class BlogPostController : BaseApiController
    {
        private readonly IBlogPostService blogPostService;

        private readonly IEnrichDomain<BlogPost> enricher;

        public BlogPostController(IBlogPostService blogPostService, IEnrichDomain<BlogPost> enricher)
        {
            this.blogPostService = blogPostService;
            this.enricher = enricher;
        }

        [HttpGet]
        [Route("posts/{id:guid}", Name = "get-blog-post")]
        public BlogPost Get(Guid id)
        {
            var post = blogPostService.Retrieve(id);

            return PrepareEnricher(enricher).ThenEnrich(post);
        }

        [HttpPost]
        [Route("posts/{id:guid}", Name = "edit-blog-post")]
        public BlogPost Edit(Guid id)
        {
            var post = blogPostService.Retrieve(id);

            return PrepareEnricher(enricher).ThenEnrich(post);
        }
    }
}