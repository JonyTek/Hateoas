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

        [JsonIgnore]
        public abstract string RouteName { get; }

        [JsonIgnore]
        protected abstract HttpMethod HttpMethod { get; }

        public abstract bool ShouldBeExposed();

        [JsonIgnore]
        public abstract RouteValueDictionary RouteValues { get; }

        [JsonIgnore]
        public User User { get; set; }

        [JsonIgnore]
        public TDomainModel Model { get; set; }        

        public string Method => HttpMethod.ToString();

        public string Href => UrlBuilderFunc(RouteName, RouteValues);

        [JsonIgnore]
        public Func<string, RouteValueDictionary, string> UrlBuilderFunc { get; set; }      
    }
}