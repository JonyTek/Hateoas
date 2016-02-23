using System;
using Hateous.Core.Model;
using Hateous.Core.Repositories;

namespace Hateous.Core.Services
{
    public class BlogPostService : IBlogPostService
    {
        private readonly IBlogPostRepository repository;

        public BlogPostService(IBlogPostRepository repository)
        {
            this.repository = repository;
        }

        public BlogPost Retrieve(Guid id)
        {
            return repository.Retrieve(id);
        }
    }
}