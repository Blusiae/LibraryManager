using LibraryManager.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryManager.Database
{
    public class BookRepository : BaseRepository<BookEntity>, IBookRepository
    {
        protected override DbSet<BookEntity> DbSet => _dbContext.Books;

        public BookRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
