using System.Net.Http;
using System.Web.Routing;
using Hateous.Core.Model;

namespace Hateous.Core.Relations
{
    public class ProductUpdateRelation : UpdateRelation<BlogPost>
    {
        public override string Rel => "edit-product";

        public override string Href
        {
            get { var helper = new UrlHelper(); }
        };

        public override bool ShouldBeExposed()
        {
            return User.HasPermissionsFor<BlogPost>(ActionType.Update);
        }

        public override RouteValueDictionary GetRouteValues()
        {
            return new RouteValueDictionary { { "productid", 1 } };
        }

        public ProductUpdateRelation(User user, BlogPost model)
            : base(user, model)
        {
        }
    }

    public interface IActionDefinition
    {
        string Action { get; }

        string Controller { get; }
    }
}