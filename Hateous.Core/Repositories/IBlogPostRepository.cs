using System;
using Hateous.Core.Model;

namespace Hateous.Core.Repositories
{
    public interface IBlogPostRepository
    {
        BlogPost Retrieve(Guid id);
    }
}