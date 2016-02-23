using System;
using System.Collections.Generic;
using System.Web.Routing;
using Hateoas.Web.Models;

namespace Hateoas.Web.Builders
{
    public class ProductResourcesBuilder : ResourceBuilderBase
    {
        public ProductResource Build(User currentUser, Product product)
        {
//            if (!AllowProduct(product))
//            {
//                return null;
//            }

            return BuildImpl(currentUser, product);
        }

        private ProductResource BuildImpl(User currentUser, Product product)
        {

            var relations = new List<IRelation>
            {
                new DeleteProduct(product.Id),
            };
        }
    }

    public class DeleteProduct : IRelation
    {
        private readonly int id;

        public DeleteProduct(int id)
        {
            this.id = id;
        }

        public string RelationName => "delete-product";
        public IActionDefinition ActionDefinition { get; }
        public RouteValueDictionary GetRouteValues()
        {
            return new RouteValueDictionary {{"productid", id}};
        }
    }

    public interface IActionDefinition
    {
        HttpVerbs Verb { get; }

        string Action { get; }

        string Controller { get; }

        //GrmPermission? Permission { get; }
    }

    public interface IRelation
    {
        string RelationName { get; }

        IActionDefinition ActionDefinition { get; }

        RouteValueDictionary GetRouteValues();
    }

    public class User
    {
        
    }

    public class ProductResource : ResourceCollection<Product>
    {
    }

    public abstract class ResourceBuilderBase
    {
    }