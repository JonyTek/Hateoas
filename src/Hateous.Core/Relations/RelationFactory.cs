using System;
using System.Web.Routing;
using Hateous.Core.Model;

namespace Hateous.Core.Relations
{
    public class RelationFactory
    {
        private readonly User user;

        private readonly Func<string, RouteValueDictionary, string> urlBuilderFunc;

        public RelationFactory(User user, Func<string, RouteValueDictionary, string> urlBuilderFunc)
        {
            this.user = user;
            this.urlBuilderFunc = urlBuilderFunc;
        }

        public IRelation Create<TRelation>(Func<TRelation> constructorFunc)
            where TRelation : IRelation
        {
            var relation = constructorFunc();

            relation.User = user;
            relation.UrlBuilderFunc = urlBuilderFunc;

            return relation;
        }
    }
}