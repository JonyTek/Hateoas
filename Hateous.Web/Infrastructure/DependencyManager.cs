using Autofac;
using Hateous.Core.Enrichers;
using Hateous.Core.Model;
using Hateous.Core.Repositories;
using Hateous.Core.Services;

namespace Hateous.Web.Infrastructure
{
    public class DependencyManager
    {
        public static void SetupDependencies(ContainerBuilder builder)
        {
            builder.RegisterType<BlogPostRepository>().As<IBlogPostRepository>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();

            builder.RegisterType<BlogPostService>().As<IBlogPostService>();
            builder.RegisterType<UserService>().As<IUserService>();

            builder.Register(x => new BlogPostEnricher()).As<IEnrichDomain<BlogPost>>();
        }
    }
}