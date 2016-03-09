using System;
using System.Web.Routing;
using Hateous.Core.Extensions;
using Hateous.Core.Model;
using Hateous.Core.Relations;

namespace Hateous.Core.Enrichers
{
    public class BlogPostEnricher : AbstractEnricher<BlogPost>
    {
        public override BlogPost ThenEnrich(BlogPost model)
        {
            model.Links.AddIfAllowed(RelationFactory.Create(() => new BlogPostUpdateRelation(model)));

            return model;
        }
    }
}