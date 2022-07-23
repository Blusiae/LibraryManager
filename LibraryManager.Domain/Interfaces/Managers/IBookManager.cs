namespace LibraryManager.Domain
{
    public interface IBookManager
    {
        List<BookDto> GetAll(string filterString, bool borrowedOnly);
        int GetBooksCountByAuthorId(int authorId);
        bool Add(BookDto bookDto, int authorId);
        BookDto GetById(int id);
        bool Delete(int bookId);
    }
}
