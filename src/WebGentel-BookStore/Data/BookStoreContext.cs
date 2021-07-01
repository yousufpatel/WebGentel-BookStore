using Microsoft.EntityFrameworkCore;

namespace WebGentel_BookStore.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
