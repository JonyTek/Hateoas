using System;
using Hateous.Core.Model;

namespace Hateous.Core.Services
{
    public interface IBlogPostService
    {
        BlogPost Retrieve(Guid id);
    }
}