using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPI_JSON_MVC4.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext()
            : base("name=BlogsDemo")
        {
        }

        public DbSet<Blog> Blogs { get; set; }
    }

    public class Blog
    {
        public int BlogId { get; set; }

        public string Name { get; set; }
    }
}