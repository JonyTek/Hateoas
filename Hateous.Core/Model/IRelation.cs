using System.Net.Http;
using System.Web.Routing;
using Newtonsoft.Json;

namespace Hateous.Core.Model
{
    public interface IRelation
    {
        bool ShouldAdd();

        string Rel { get; }

        string Href { get; }

        string Method { get; }

        RouteValueDictionary GetRouteValues();
    }
}