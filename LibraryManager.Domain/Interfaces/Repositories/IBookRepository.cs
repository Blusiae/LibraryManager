namespace LibraryManager.Domain
{
    public interface IBookRepository : IRepository<BookEntity>
    {
        bool Borrow(int id);
        bool Unborrow(int id);
    }
}
