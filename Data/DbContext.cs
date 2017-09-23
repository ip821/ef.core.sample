using Microsoft.EntityFrameworkCore;
using sample1.Entities;

namespace sample1.Data
{
    public class CustomDbContext : DbContext
    {
        public CustomDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=sample.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().Property(a => a.Name).IsRequired();
        }
    }
}