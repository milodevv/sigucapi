using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace sigucapi.Models
{
    public class ProvidersContext : DbContext
    {
        public ProvidersContext(DbContextOptions<ProvidersContext> options) : base(options) { }

        public DbSet<ProvidersDTO> Providers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProvidersDTO>().HasIndex(e => e.id).IsUnique();
        }
    }
}
