using BookWeb_MVC_.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BookWeb_MVC_.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Catagory> Categories { get; set; }
    }
}
