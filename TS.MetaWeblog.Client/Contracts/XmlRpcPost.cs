using System;
using CookComputing.XmlRpc;

namespace TS.MetaWeblog.Client.Contracts
{
    [XmlRpcMissingMapping(MappingAction.Ignore)]
    public struct XmlRpcPost
    {
        public DateTime dateCreated;
        public string description;
        public string title;
        public string postid;
        public string link;
        public string[] categories;
        public string mt_keywords;
    }
}
