namespace LibraryManager.Domain
{
    public interface IBorrowRepository : IRepository<BorrowEntity>
    {
        bool Return(int id);
    }
}
