namespace LibraryManager.Domain
{
    public interface IBookManager
    {
        IEnumerable<BookDto> GetAll(string filterString, bool borrowedOnly);
        bool Add(BookDto book);
        bool Delete(BookDto book);
    }
}
