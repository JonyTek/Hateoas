using System;
using System.Collections.Generic;
using Hateous.Core.Model;

namespace Hateous.Core.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User RetRetrieve(Guid id)
        {
            var admin = new Role
            {
                Id = Guid.NewGuid(),
                Name = "Administrator",
                Permissions = new Dictionary<Type, ActionType[]>
                {
                    {
                        typeof (BlogPost), new[]
                        {
                            ActionType.Create, ActionType.Update,
                            ActionType.Delete, ActionType.Read,
                        }
                    }
                }
            };

            return new User
            {
                Id = Guid.NewGuid(),
                Roles = new[] { admin },
                Username = "Administrator"
            };
        }
    }
}