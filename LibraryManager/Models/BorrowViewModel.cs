namespace LibraryManager
{
    public class BorrowViewModel
    {
        public ReaderViewModel Reader { get; set; }
        public BookViewModel Book { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDeadline { get; set; }
        public DateTime? ReturnDate { get; set; }
        public bool IsReturned { get; set; }
    }
}
