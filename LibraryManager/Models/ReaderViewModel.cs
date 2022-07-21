namespace LibraryManager
{
    public class ReaderViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public List<BorrowViewModel> Borrows { get; set; }
    }
}
