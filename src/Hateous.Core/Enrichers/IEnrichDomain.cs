using System;
using System.Web.Routing;
using Hateous.Core.Model;

namespace Hateous.Core.Enrichers
{
    public interface IEnrichDomain<TDomainModel>
        where TDomainModel : IDomainModel
    {
        TDomainModel ThenEnrich(TDomainModel model);

        TDomainModel Enrich(User user, Func<string, RouteValueDictionary, string> buildUrlFunc, TDomainModel model);

        IEnrichDomain<TDomainModel> Prepare(User currentUser, Func<string, RouteValueDictionary, string> buildUrlFunc);
    }
}