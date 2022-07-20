using LibraryManager.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryManager.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<BookEntity> Books { get; set; }
        public DbSet<ReaderEntity> Readers { get; set; }
        public DbSet<AuthorEntity> Authors { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
