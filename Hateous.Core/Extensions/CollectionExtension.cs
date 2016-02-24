using System.Collections.Generic;
using Hateous.Core.Model;
using Hateous.Core.Relations;

namespace Hateous.Core.Extensions
{
    public static class CollectionExtension
    {
        public static void AddIfAllowed(this ICollection<IRelation> collection, IRelation relation)
        {
            if (relation.ShouldBeExposed())
            {
                collection.Add(relation);
            }
        }
    }
}