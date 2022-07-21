namespace LibraryManager.Domain
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int PublishYear { get; set; }
        public bool IsBorrowed { get; set; }
        public AuthorDto Author { get; set; }
        public List<BorrowDto> Borrows { get; set; }
    }
}
