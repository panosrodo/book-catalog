using Microsoft.EntityFrameworkCore;

namespace BookCatalog.Data
{
    public class BookCatalogDBContext : DbContext
    {
        public BookCatalogDBContext(DbContextOptions<BookCatalogDBContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
