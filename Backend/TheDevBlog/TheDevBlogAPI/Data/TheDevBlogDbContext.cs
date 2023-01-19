using Microsoft.EntityFrameworkCore;
using TheDevBlogAPI.Models.Entities;

namespace TheDevBlogAPI.Data
{
    public class TheDevBlogDbContext: DbContext
    {
        public TheDevBlogDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Posts> Posts { get; set; } 
    }
}
