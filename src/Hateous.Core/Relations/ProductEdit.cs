using System.Web.Routing;
using Hateous.Core.Model;

namespace Hateous.Core.Relations
{
    public class ProductEdit : UpdateRelation<BlogPost>
    {
        public override bool ShouldAdd()
        {
            return User.HasPermissionsFor<BlogPost>(ActionType.Update);
        }

        public override string Rel => "edit-product";

        public override string Href
        {
            get { return "XXXXXXX"; }
        }

        public override RouteValueDictionary GetRouteValues()
        {
            return new RouteValueDictionary { { "productid", 1 } };
        }

        public ProductEdit(User user, BlogPost model)
            : base(user, model)
        {
        }
    }
}