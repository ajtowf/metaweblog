using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookComputing.XmlRpc;
using TS.MetaWeblog.Client.Interfaces;
using TS.MetaWeblog.Client.Models;

namespace TS.MetaWeblog.Client
{
    public class MetaWeblogClient : IMetaWeblogClient
    {
        private readonly IMetaWeblogRpc wrapper;

        private readonly string username;
        private readonly string password;
        private readonly int blogId;        

        public MetaWeblogClient(string url, string username, string password)
            : this(url, username, password, 0)
        {
        }

        public MetaWeblogClient(string url, string username, string password, int blogId)            
        {
            this.username = username;
            this.password = password;
            this.blogId = blogId;

            wrapper = (IMetaWeblogRpc)XmlRpcProxyGen.Create(typeof(IMetaWeblogRpc));
            wrapper.Url = url;
        }

        public Task<Post> GetPostAsync(string postId)
        {
            return Task.Factory.StartNew(() =>
                ModelFactory.FromContract(
                    wrapper.GetPost(postId, username, password)));
        }

        public Task<IEnumerable<Post>> GetRecentPostsAsync(int numberOfPosts)
        {
            return Task.Factory.StartNew(() => 
                wrapper
                .GetRecentPosts(blogId, username, password, numberOfPosts)
                .Select(ModelFactory.FromContract));
        }
    }
}
