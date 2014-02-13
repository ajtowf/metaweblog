using System.Collections.Generic;
using System.Threading.Tasks;
using TS.MetaWeblog.Client.Models;

namespace TS.MetaWeblog.Client.Interfaces
{
    public interface IMetaWeblogClient
    {
        Task<Post> GetPostAsync(string postId);
        Task<IEnumerable<Post>> GetRecentPostsAsync(int numberOfPosts);
    }
}
