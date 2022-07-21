namespace LibraryManager.Domain
{
    public interface IAuthorManager
    {
        AuthorDto GetAuthorForBook(BookDto book);
        bool Add(AuthorDto authorDto);
    }
}
