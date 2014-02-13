using CookComputing.XmlRpc;
using TS.MetaWeblog.Client.Contracts;

namespace TS.MetaWeblog.Client.Interfaces
{
    public interface IMetaWeblogRpc : IXmlRpcProxy
    {
        [XmlRpcMethod("metaWeblog.getRecentPosts")]
        XmlRpcPost[] GetRecentPosts(int blogId, string username, string password, int numberOfPosts);

        [XmlRpcMethod("metaWeblog.getPost")]
        XmlRpcPost GetPost(string postid, string username, string password);
    }
}
