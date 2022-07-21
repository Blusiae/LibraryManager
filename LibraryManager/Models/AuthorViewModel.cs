namespace LibraryManager
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<BookViewModel>? Books { get; set; }
    }
}
