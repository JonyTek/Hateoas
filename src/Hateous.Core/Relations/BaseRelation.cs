using System;
using System.Net.Http;
using System.Web.Routing;
using Hateous.Core.Model;
using Newtonsoft.Json;

namespace Hateous.Core.Relations
{
    public abstract class BaseRelation<TDomainModel>
        where TDomainModel : IDomainModel
    {
        protected BaseRelation(TDomainModel model)
        {
            Model = model;
        }

        public abstract string Rel { get; }

        public string Method => HttpMethod.ToString();

        public string Href => UrlBuilderFunc(RouteName, RouteValues);

        protected abstract string RouteName { get; }

        protected abstract HttpMethod HttpMethod { get; }

        protected abstract RouteValueDictionary RouteValues { get; }

        [JsonIgnore]
        public User User { get; set; }

        protected TDomainModel Model { get; set; }        

        [JsonIgnore]
        public Func<string, RouteValueDictionary, string> UrlBuilderFunc { get; set; }

        public abstract bool ShouldBeExposed();
         
    }
}