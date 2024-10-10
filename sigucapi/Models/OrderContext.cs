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
            modelBuilder.Entity<OrderData>().HasIndex(e => e.id).IsUnique();
            modelBuilder.Entity<OrderData>().Property(e => e.net_weight).HasColumnType("decimal(18, 2)");
            modelBuilder.Entity<OrderData>().Property(e => e.gross_weight).HasColumnType("decimal(18, 2)");
        }
    }
}
