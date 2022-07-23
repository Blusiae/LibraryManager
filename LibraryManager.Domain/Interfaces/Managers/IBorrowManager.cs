namespace LibraryManager.Domain
{
    public interface IBorrowManager
    {
        List<BorrowDto> GetAll();
        List<BorrowDto> GetBorrowsByBookId(int bookId);
        List<BorrowDto> GetBorrowsByReaderId(int readerId);
        List<BorrowDto> GetAllCurrentBorrows();
        bool Add(BorrowDto borrowDto, int bookId, int readerId);
        bool Delete(int borrowId, int bookId);
        bool BookReturn(int borrowId, int bookId);
    }
}
