using LibraryManager.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryManager.Database
{
    public class AuthorRepository : BaseRepository<AuthorEntity>, IAuthorRepository
    {
        protected override DbSet<AuthorEntity> DbSet => _dbContext.Authors;

        public AuthorRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
