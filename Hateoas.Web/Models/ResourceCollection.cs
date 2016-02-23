using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Hateoas.Web.Models
{
    public abstract class ResourceCollection<TResource> : Resource
       where TResource : Resource
    {
        protected ResourceCollection()
        {
            Resources = new Collection<TResource>();
        }

        public ICollection<TResource> Resources { get; set; }
    }

    public abstract class Resource
    {
        protected Resource()
        {
            Links = new List<Link>();
        }

        public IList<Link> Links { get; set; }
    }

    public class Link
    {
        public Link(string rel, string href, HttpVerbs verb)
        {
            Rel = rel;
            Href = href;
            Verb = verb.ToString();
        }

        public string Rel { get; private set; }

        public string Href { get; private set; }

        public string Verb { get; private set; }
    }

    public enum HttpVerbs
    {
        Get = 1,

        Post = 2,

        Put = 4,

        Delete = 8,

        Head = 16,

        Patch = 32,

        Options = 64,
    }
}