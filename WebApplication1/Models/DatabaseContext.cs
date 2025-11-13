using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Entites;


namespace WebApplication1.Models.Entites
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
              : base(options)
        { }
        public DbSet<Product> Products { get; set; }
    }
}