using System;
using Hateous.Core.Model;

namespace Hateous.Core.Repositories
{
    public class BlogPostRepository : IBlogPostRepository
    {
        public BlogPost Retrieve(Guid id)
        {
            return new BlogPost
            {
                Id = id,
                Title = "My first blog post"
            };
        }
    }
}