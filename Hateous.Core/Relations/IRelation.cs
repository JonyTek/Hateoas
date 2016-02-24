using System.Web.Routing;

namespace Hateous.Core.Relations
{
    public interface IRelation
    {
        bool ShouldBeExposed();

        string Rel { get; }

        string Href { get; }

        string Method { get; }

        RouteValueDictionary GetRouteValues();
    }
}