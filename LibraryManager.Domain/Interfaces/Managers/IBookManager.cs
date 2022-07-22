namespace LibraryManager.Domain
{
    public interface IBookManager
    {
        IEnumerable<BookDto> GetAll(string filterString, bool borrowedOnly);
        BookDto GetById(int id);
        bool Add(BookDto bookDto);
        bool Delete(BookDto bookDto);
    }
}
