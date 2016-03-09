using System;
using System.Collections.Generic;
using Hateous.Core.Relations;

namespace Hateous.Core.Extensions
{
    public static class CollectionExtension
    {
        public static void AddIfAllowed(this ICollection<IRelation> collection, IRelation relation)
        {
            if (relation.User == null || relation.UrlBuilderFunc == null)
            {
                throw new InvalidOperationException("you must add relations via the relation factory");
            }

            if (relation.ShouldBeExposed())
            {
                collection.Add(relation);
            }
        }
    }
}