using BloggieProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggieProject.Entities.Contexts
{
    public class BloggieProjectDbContext : DbContext
    {
        public BloggieProjectDbContext(DbContextOptions<BloggieProjectDbContext> options) : base(options) { }

        public DbSet<BlogPost> BlogPosts  { get; set; }
        public DbSet<Tag> Tags  { get; set; }
        public DbSet<BlogPostLike> BlogPostLikes  { get; set; }

    }
}
