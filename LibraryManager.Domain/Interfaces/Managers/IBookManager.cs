namespace LibraryManager.Domain
{
    public interface IBookManager
    {
        List<BookDto> GetAll(string filterString, bool borrowedOnly);
        bool Add(BookDto bookDto);
        bool Delete(BookDto bookDto);
    }
}
