using System;
using System.Collections.Generic;
using Hateous.Core.Relations;

namespace Hateous.Core.Model
{
    public interface IDomainModel
    {
        Guid Id { get; set; }

        ICollection<IRelation> Links { get; }
    }
}