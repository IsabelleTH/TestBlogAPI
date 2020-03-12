using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBlogAPI.Models
{
    public class BlogPost
    {
        public BlogPost()
        {

        }

        public BlogPost(string url)
        { 

        }

        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public string Introduction { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime PublishDateString { get; set; }
    }
}
