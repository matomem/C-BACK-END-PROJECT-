using Microsoft.EntityFrameworkCore;
using CryptoExchange.Backend.Models;

namespace CryptoExchange.Backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        // You can add other DbSet properties for other entities here

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure your entity mappings or constraints here if needed
        }
    }
} 