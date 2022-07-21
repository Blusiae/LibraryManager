namespace LibraryManager.Domain
{
    public class ReaderDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public List<BorrowDto> Borrows { get; set; }
    }
}
