using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace NetConstructBlogPage.Models
{
    public class Blog
    {
        public class blogPost
        {
            public int blogId { get; set; }
            public int id { get; set; }
            public DateTime date { get; set; }
            public string title { get; set; }
            public string image { get; set; }
            public string htmlContent { get; set; }
            public List<comment> Comments { get; set; }
            public Root root { get; set; }
        }

        public class comment
        {
            public int blogId { get; set; }
            public string name { get; set; }
            public DateTime date { get; set; }
            public string emailAddress { get; set; }
            public string message { get; set; }
        }

        public class Root
        {
            public int blogId { get; set; }
            public List<blogPost> BlogPosts { get; set; }
        }
    }
    
}
