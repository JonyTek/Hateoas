using System.Net.Http;
using Hateous.Core.Model;

namespace Hateous.Core.Relations
{
    public abstract class UpdateRelation<TDomainModel> : BaseRelation<TDomainModel>, IRelation
        where TDomainModel : IDomainModel
    {
        protected UpdateRelation(TDomainModel model)
            : base(model)
        {
        }

        protected override HttpMethod HttpMethod => HttpMethod.Post;
    }
}