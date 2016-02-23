using System;
using System.Collections.Generic;
using System.Linq;

namespace Hateous.Core.Model
{
    public class User
    {
        public Guid Id { get; set; }

        public string Username { get; set; }

        public IEnumerable<Role> Roles { get; set; }

        public User()
        {
            Roles = new List<Role>();
        }

        public bool HasPermissionsFor<TDomainModel>(ActionType action)
            where TDomainModel : IDomainModel
        {
            var role = Roles.FirstOrDefault(x => x.Can<TDomainModel>(action));
            return role != null;
        }
    }
}