using LibraryManager.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryManager.Database
{
    public class BorrowRepository : BaseRepository<BorrowEntity>, IBorrowRepository
    {
        protected override DbSet<BorrowEntity> DbSet => _dbContext.Borrows;

        public BorrowRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public bool Return(int id)
        {
            var borrow = DbSet.FirstOrDefault(x => x.Id == id);
            borrow.IsReturned = true;
            borrow.ReturnDate = DateTime.Today;
            return _dbContext.SaveChanges() > 0;
        }
    }
}
