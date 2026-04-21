using Microsoft.EntityFrameworkCore;
using SalesRealApp.Models;

namespace SalesRealApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sale>()
                .Property(p => p.Price)
                .HasPrecision(18, 4); // total 18 digits, 4 after decimal
        }
    }
}
