using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices.Marshalling;

namespace sigucapi.Models
{
    public class ProformaContext : DbContext
    {
        public ProformaContext(DbContextOptions<ProformaContext> options) : base(options) { }

        public DbSet<Proforma> Proforma {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Proforma>().Property(e => e.net_weight).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Proforma>().Property(e => e.gross_weight).HasColumnType("decimal(18,2)");
        }
    }
}
