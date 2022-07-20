using LibraryManager.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryManager.Database
{
    public class ReaderRepository : BaseRepository<ReaderEntity>, IReaderRepository
    {
        protected override DbSet<ReaderEntity> DbSet => _dbContext.Readers;

        public ReaderRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
