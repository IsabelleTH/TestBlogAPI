using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBlogAPI.Models
{
   public class BlogResult
    {
        public List<BlogPost> Posts{ get; set; }
        public int TotalPages { get; set; }
        public int Page { get; set; }
    }
}

