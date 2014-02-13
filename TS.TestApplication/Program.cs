using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using TS.MetaWeblog.Client;
using TS.MetaWeblog.Client.Interfaces;
using TS.MetaWeblog.Client.Models;

namespace TS.TestApplication
{
    class Program
    {
        private static IMetaWeblogClient client = new MetaWeblogClient(
            ConfigurationManager.AppSettings.Get("Url"),
            ConfigurationManager.AppSettings.Get("Username"),
            ConfigurationManager.AppSettings.Get("Password"),
            int.Parse(ConfigurationManager.AppSettings.Get("BlogId")));

        static void Main()
        {
            var posts = GetPosts().Result;
            foreach (var post in posts)
            {
                Console.WriteLine(post.PostId);
                Console.WriteLine(post.Title);
                Console.WriteLine(post.Created);
                Console.WriteLine(post.Link);
                Console.WriteLine(post.Categories);
                Console.WriteLine(post.Tags);                
                Console.WriteLine(post.Body);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static async Task<IEnumerable<Post>> GetPosts()
        {
            return await client.GetRecentPostsAsync(1);
        }
    }
}
