namespace LibraryManager.Domain
{
    public interface IBorrowManager
    {
        public IEnumerable<BorrowDto> GetAll();
        public bool Add(BorrowDto borrowDto);
    }
}
