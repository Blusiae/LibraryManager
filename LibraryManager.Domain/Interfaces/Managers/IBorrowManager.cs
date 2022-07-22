namespace LibraryManager.Domain
{
    public interface IBorrowManager
    {
        public List<BorrowDto> GetAll();
        public List<BorrowDto> GetBorrowsByBookId(int bookId);
        public bool Add(BorrowDto borrowDto);
    }
}
