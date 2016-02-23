using System;
using System.Collections.Generic;

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