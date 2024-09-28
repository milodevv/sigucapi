using Microsoft.EntityFrameworkCore;

namespace sigucapi.Models
{
    public class SalesOrderContext : DbContext
    {
        public SalesOrderContext(DbContextOptions<SalesOrderContext> options) : base(options) { }

        public DbSet<SalesOrder> SalesOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SalesOrder>().HasIndex(e => e.id).IsUnique();
        }
    }
}
