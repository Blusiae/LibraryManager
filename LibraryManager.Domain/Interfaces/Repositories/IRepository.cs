namespace LibraryManager.Domain
{
    public interface IRepository<Entity> where Entity : class
    {
        IEnumerable<Entity> GetAll();
        bool Add(Entity entity);
        bool Delete(Entity entity);
    }
}
