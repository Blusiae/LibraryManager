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
    }
}
