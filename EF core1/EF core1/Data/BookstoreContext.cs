using EF_core1.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_core1.Data
{
    public class BookstoreContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ReadMoreBooksDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
