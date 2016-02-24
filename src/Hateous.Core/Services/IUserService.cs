using System;
using Hateous.Core.Model;

namespace Hateous.Core.Services
{
    public interface IUserService
    {
        User Retrieve(Guid id);
    }
}