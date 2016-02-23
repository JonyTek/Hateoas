﻿using System.Net.Http;
using Hateous.Core.Model;
using Newtonsoft.Json;

namespace Hateous.Core.Relations
{
    public abstract class BaseRelation<TDomainModel>
        where TDomainModel : IDomainModel
    {
        protected User User;

        protected TDomainModel Model;

        public abstract bool ShouldAdd();

        public abstract string Rel { get; }

        public abstract string Href { get; }

        //[JsonIgnore]
        protected abstract HttpMethod HttpMethod { get; }

        public string Method => HttpMethod.ToString();

        protected BaseRelation(User user, TDomainModel model)
        {
            User = user;
            Model = model;
        }
    }
}