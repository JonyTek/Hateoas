using System.Web.Routing;
using Hateous.Core.Model;

namespace Hateous.Core.Relations
{
    public class BlogPostUpdateRelation : UpdateRelation<BlogPost>
    {
        public BlogPostUpdateRelation(BlogPost model) : base(model)
        {
        }

        public override string Rel => "edit-blog-post";

        public override string RouteName => "edit-blog-post";

        public override RouteValueDictionary RouteValues => new RouteValueDictionary {{"id", Model.Id}};

        public override bool ShouldBeExposed()
        {
            return User.HasPermissionsFor<BlogPost>(ActionType.Update);
        }
    }
}