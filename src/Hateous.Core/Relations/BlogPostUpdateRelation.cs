using System.Web.Routing;
using Hateous.Core.Model;
using Hateous.Core.Util;

namespace Hateous.Core.Relations
{
    public class BlogPostUpdateRelation : UpdateRelation<BlogPost>
    {
        public BlogPostUpdateRelation(BlogPost model)
            : base(model)
        {
        }

        public override string Rel => "edit-blog-post";

        protected override string RouteName => Routes.BlogPost.EditBlogPost;

        protected override RouteValueDictionary RouteValues => new RouteValueDictionary {{"id", Model.Id}};

        public override bool ShouldBeExposed()
        {
            return User.HasPermissionsFor<BlogPost>(ActionType.Update);
        }
    }
}