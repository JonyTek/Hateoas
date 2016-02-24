using System;
using System.Net.Http;
using System.Web.Routing;
using Hateous.Core.Model;

namespace Hateous.Core.Relations
{
    public abstract class UpdateRelation<TDomainModel> : BaseRelation<TDomainModel>, IRelation
        where TDomainModel : IDomainModel
    {
        protected override HttpMethod HttpMethod => HttpMethod.Post;

        public abstract RouteValueDictionary GetRouteValues();

        protected UpdateRelation(User user, TDomainModel model)
            : base(user, model)
        {
        }
    }
}