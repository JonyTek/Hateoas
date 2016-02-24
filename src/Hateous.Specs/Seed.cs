using System;
using System.Collections.Generic;
using Hateous.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hateous.Specs
{
    [TestClass]
    public class Seed
    {
        [TestMethod]
        public void SeedPermissionData()
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

            var adminUser = new User
            {
                Id = Guid.NewGuid(),
                Roles = new[] {admin},
                Username = "Administrator"
            };
        }
    }
}
