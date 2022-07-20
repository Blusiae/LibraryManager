using Microsoft.EntityFrameworkCore;

namespace LibraryManager.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
