using LibraryManager.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryManager.Database
{
    /// <summary>
    /// Base repository class from which all repositories inherite.
    /// </summary>
    /// <typeparam name="Entity"></typeparam>
    public abstract class BaseRepository<Entity> : IRepository<Entity> where Entity : BaseEntity
    {
        protected ApplicationDbContext _dbContext;
        protected abstract DbSet<Entity> DbSet { get; }

        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Entity> GetAll()
        {
            return DbSet.Select(x => x); //Select method returns IEnumerable.
        }

        public bool Add(Entity entity)
        {
            DbSet.Add(entity);
            return _dbContext.SaveChanges() > 0;
        }

        public Entity GetById(int id)
        {
            return DbSet.FirstOrDefault(x => x.Id == id);
        }

        public bool Delete(Entity entity)
        {
            var entityToDelete = DbSet.FirstOrDefault(x => x.Id == entity.Id); //entity param may not have all properties so it's better to find it by Id

            if(entityToDelete != null) //Check if entity has been found in database.
            {
                DbSet.Remove(entityToDelete);
                return _dbContext.SaveChanges() > 0;
            }

            return false; //Entity hasn't been found, so it hasn't been deleted.
        }
    }
}
