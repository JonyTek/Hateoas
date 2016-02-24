using System;
using Hateous.Core.Model;
using Hateous.Core.Repositories;

namespace Hateous.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public User Retrieve(Guid id)
        {
            return userRepository.RetRetrieve(id);
        }
    }
}