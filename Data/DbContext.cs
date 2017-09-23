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
            modelBuilder.Entity<Book>();
            modelBuilder.Entity<AuthorBook>().HasKey(ab => new { ab.AuthorId, ab.BookId });
            modelBuilder.Entity<AuthorBook>().HasOne(ab => ab.Author).WithMany();
            modelBuilder.Entity<AuthorBook>().HasOne(ab => ab.Book).WithMany(b => b.AuthorBooks);
        }
    }
}