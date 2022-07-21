namespace LibraryManager.Domain
{
    public interface IBorrowManager
    {
        public List<BorrowDto> GetAll();
        public bool Add(BorrowDto borrowDto);
    }
}
