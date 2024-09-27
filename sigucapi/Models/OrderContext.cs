using Microsoft.EntityFrameworkCore;

namespace sigucapi.Models
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {

        }

        public DbSet<OrderData> OrderData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OrderData>().HasIndex(e => e.Id).IsUnique();
        }
    }
}
