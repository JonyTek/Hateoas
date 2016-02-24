using System;
using System.Collections.Generic;
using Hateous.Core.Relations;

namespace Hateous.Core.Model
{
    public class Resource : IDomainModel
    {
        public Guid Id { get; set; }

        public ICollection<IRelation> Links { get; }

        public Resource()
        {
            Links = new List<IRelation>();
        }
    }
}