using System;
using System.Collections.Generic;
using System.Linq;

namespace Hateous.Core.Model
{
    public class Role
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Dictionary<Type, ActionType[]> Permissions { get; set; }

        public Role()
        {
            Permissions = new Dictionary<Type, ActionType[]>();
        }

        public bool Can<TDomainModel>(ActionType performAction)
           where TDomainModel : IDomainModel
        {
            var type = typeof(TDomainModel);
            if (Permissions.ContainsKey(type))
            {
                var validActions = Permissions[type];
                return validActions.Contains(performAction);
            }

            return false;
        }
    }

}