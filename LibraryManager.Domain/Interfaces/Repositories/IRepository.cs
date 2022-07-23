namespace LibraryManager.Domain
{
    public interface IRepository<Entity> where Entity : class
    {
        IEnumerable<Entity> GetAll();
        Entity GetById(int id);
        bool Add(Entity entity);
        bool Delete(int entityId);
    }
}
