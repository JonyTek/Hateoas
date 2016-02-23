using System;
using System.Collections.Generic;

namespace Hateous.Core.Model
{
    public interface IDomainModel
    {
        Guid Id { get; set; }

        ICollection<IRelation> Links { get; }
    }
}