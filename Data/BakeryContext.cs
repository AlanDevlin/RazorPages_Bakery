using learning_dotnet.Models;
using learning_dotnet.Data.Configurations;
using learning_dotnet.Data;
using Microsoft.EntityFrameworkCore;

namespace learning_dotnet.Data
{
    public class BakeryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=Bakery.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
        modelBuilder.ApplyConfiguration(new ProductConfiguration()).Seed();
         }
    }
}