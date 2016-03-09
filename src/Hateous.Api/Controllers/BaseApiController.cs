using System;
using System.Web;
using System.Web.Http;
using Hateous.Core.Enrichers;
using Hateous.Core.Model;
using Hateous.Core.Services;

namespace Hateous.Api.Controllers
{
    public class BaseApiController : ApiController
    {
        public IUserService UserService { get; set; }

        //Would wire this up to Auth
        protected User CurrentUser => UserService.Retrieve(Guid.Empty);

        protected IEnrichDomain<TDomainModel> PrepareEnricher<TDomainModel>(IEnrichDomain<TDomainModel> enricher)
            where TDomainModel : IDomainModel
        {
            return enricher.Prepare(CurrentUser, Url.Link);
        } 
    }
}
