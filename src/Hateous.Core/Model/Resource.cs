using System;
using System.Collections.Generic;
using Hateous.Core.Relations;

namespace Hateous.Core.Model
{
    public class Resource : IDomainModel
    {
        public Resource()
        {
            Links = new List<IRelation>();
        }

        public Guid Id { get; set; }

        public ICollection<IRelation> Links { get; }
    }
}