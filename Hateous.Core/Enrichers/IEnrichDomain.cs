using Hateous.Core.Model;

namespace Hateous.Core.Enrichers
{
    public interface IEnrichDomain<TDomainModel>
        where TDomainModel : IDomainModel
    {
        TDomainModel Enrich(User user, TDomainModel model);
    }
}