using System.Collections.Generic;
using Hateous.Core.Model;

namespace Hateous.Core.Extensions
{
    public static class CollectionExtension
    {
        public static void AddIfAllowed(this ICollection<IRelation> collection, IRelation relation)
        {
            if (relation.ShouldAdd())
            {
                collection.Add(relation);
            }
        }
    }
}