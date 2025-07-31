using BookSpace.Models;
using Microsoft.EntityFrameworkCore;
namespace BookSpace.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { DisplayOrder = "1", Id = 100, Name ="Action"},
                new Category { DisplayOrder ="2",Id = 101, Name = "Sci-fi"},
                new Category { DisplayOrder = "3", Id = 102, Name = "History"}              
                ); 
        }
    }
}

