namespace LibraryManager.Domain
{
    public interface IBorrowManager
    {
        public List<BorrowDto> GetAll();
        public List<BorrowDto> GetBorrowsByBookId(int bookId);
        public List<BorrowDto> GetBorrowsByReaderId(int readerId);
        public List<BorrowDto> GetAllCurrentBorrows();
        public bool Add(BorrowDto borrowDto);
    }
}
