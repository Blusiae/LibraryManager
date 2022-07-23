namespace LibraryManager
{
    public class ReaderViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime Birthdate { get; set; }
        public List<BorrowViewModel>? Borrows { get; set; }
    }
}
