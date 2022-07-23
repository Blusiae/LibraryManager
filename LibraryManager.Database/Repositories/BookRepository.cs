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

        public bool Borrow(int id)
        {
            var book = _dbContext.Books.FirstOrDefault(x => x.Id == id);
            book.IsBorrowed = true;
            return _dbContext.SaveChanges() > 0;
        }

        public bool Unborrow(int id)
        {
            var book = _dbContext.Books.FirstOrDefault(x => x.Id == id);
            book.IsBorrowed = false;
            return _dbContext.SaveChanges() > 0;
        }
    }
}
