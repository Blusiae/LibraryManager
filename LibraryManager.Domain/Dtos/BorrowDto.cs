namespace LibraryManager.Domain
{
    public class BorrowDto
    {
        public int Id { get; set; }
        public ReaderDto Reader { get; set; }
        public BookDto Book { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDeadline { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool IsReturned { get; set; }
    }
}
