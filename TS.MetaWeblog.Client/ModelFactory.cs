using TS.MetaWeblog.Client.Contracts;
using TS.MetaWeblog.Client.Models;

namespace TS.MetaWeblog.Client
{
    public class ModelFactory
    {
        public static Post FromContract(XmlRpcPost source)
        {
            return new Post
            {
                PostId = source.postid,
                Created = source.dateCreated,
                Title = source.title,
                Body = source.description,
                Categories = source.categories,
                Tags = source.mt_keywords.Split(','),
                Link = source.link
            };
        }
    }
}
