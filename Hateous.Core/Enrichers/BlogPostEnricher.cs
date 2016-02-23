using Hateous.Core.Extensions;
using Hateous.Core.Model;
using Hateous.Core.Relations;

namespace Hateous.Core.Enrichers
{
    public class BlogPostEnricher : IEnrichDomain<BlogPost>
    {
        public BlogPost Enrich(User user, BlogPost model)
        {
            model.Links.AddIfAllowed(new ProductEdit(user, model));

            return model;
        }
    }
}