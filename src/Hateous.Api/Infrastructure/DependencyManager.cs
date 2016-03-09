using System.Web;
using Autofac;
using Hateous.Api.Controllers;
using Hateous.Core.Enrichers;
using Hateous.Core.Model;
using Hateous.Core.Repositories;
using Hateous.Core.Services;

namespace Hateous.Api.Infrastructure
{
    public class DependencyManager
    {
        public static void SetupDependencies(ContainerBuilder builder)
        {
            //Repositories
            builder.RegisterType<BlogPostRepository>().As<IBlogPostRepository>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();

            //Services
            builder.RegisterType<BlogPostService>().As<IBlogPostService>();
            builder.RegisterType<UserService>().As<IUserService>();

            //Enrichers
            builder.Register(x => new BlogPostEnricher()).As<IEnrichDomain<BlogPost>>();

            //Autowire controller
            builder.RegisterAssemblyTypes(typeof (BaseApiController).Assembly)
                .AssignableTo<BaseApiController>()
                .OnActivated(args =>
                {
                    var controller = args.Instance as BaseApiController;
                    if (controller != null)
                    {
                        controller.UserService = args.Context.Resolve<IUserService>();
                    }
                });
        }
    }
}