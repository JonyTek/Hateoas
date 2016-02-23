using System;
using Hateous.Core.Model;

namespace Hateous.Core.Repositories
{
    public interface IUserRepository
    {
        User RetRetrieve(Guid id);
    }
}