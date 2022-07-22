namespace LibraryManager.Domain
{
    public interface IBookManager
    {
        List<BookDto> GetAll(string filterString, bool borrowedOnly);
        bool Add(BookDto bookDto, int authorId);
        bool Delete(BookDto bookDto);
    }
}
