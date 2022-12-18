using Microsoft.EntityFrameworkCore;
using hackathon.Models;

namespace hackathon.Models
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options)
           : base(options)
        {

        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Products> Products { get; set; }

    }
}
