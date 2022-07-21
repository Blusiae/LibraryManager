namespace LibraryManager
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PublishYear { get; set; }
        public bool IsBorrowed { get; set; }
        public AuthorViewModel Author { get; set; } 
        public List<BorrowViewModel> Borrows { get; set; }
    }
}
