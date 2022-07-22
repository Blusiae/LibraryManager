namespace LibraryManager.Domain
{
    public interface IBookManager
    {
        List<BookDto> GetAll(string filterString, bool borrowedOnly);
        bool Add(BookDto bookDto, int authorId);
        BookDto GetById(int id);
        bool Delete(BookDto bookDto);
    }
}
