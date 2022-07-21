namespace LibraryManager.Domain
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; }
        public IEnumerable<BookDto> Books { get; set; }
    }
}
