using System;
using System.Web.Routing;
using Hateous.Core.Model;

namespace Hateous.Core.Relations
{
    public interface IRelation
    {
        bool ShouldBeExposed();

        User User { get; set; }

        Func<string, RouteValueDictionary, string> UrlBuilderFunc { get; set; }
    }
}