using System;
using System.Web.Routing;
using Hateous.Core.Model;
using Hateous.Core.Relations;

namespace Hateous.Core.Enrichers
{
    public abstract class AbstractEnricher<TDomainModel> : IEnrichDomain<TDomainModel>
        where TDomainModel : IDomainModel
    {
        protected User User { get; private set; }

        protected RelationFactory RelationFactory { get; private set; }

        protected Func<string, RouteValueDictionary, string> BuildUrlFunc { get; private set; }

        public abstract TDomainModel ThenEnrich(TDomainModel model);

        public IEnrichDomain<TDomainModel> Prepare(User user, Func<string, RouteValueDictionary, string> buildUrlFunc)
        {
            User = user;
            BuildUrlFunc = buildUrlFunc;
            RelationFactory = new RelationFactory(user, buildUrlFunc);

            return this;
        }

        public TDomainModel Enrich(User user, Func<string, RouteValueDictionary, string> buildUrlFunc,
            TDomainModel model)
        {
            return Prepare(user, buildUrlFunc).ThenEnrich(model);
        }
    }
}