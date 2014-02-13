using System;

namespace TS.MetaWeblog.Client.Models
{
    public class Post
    {
        public string PostId { get; set; }

        public string Title { get; set; }        
        public string Body { get; set; }
        
        public string Link { get; set; }
        public string[] Categories { get; set; }
        public string[] Tags { get; set; }

        public DateTime Created { get; set; }
    }
}
