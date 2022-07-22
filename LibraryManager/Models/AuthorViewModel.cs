namespace LibraryManager
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public List<BookViewModel>? Books { get; set; }
    }
}
