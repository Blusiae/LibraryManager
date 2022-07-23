namespace LibraryManager.Domain
{
    public interface IReaderManager
    {
        List<ReaderDto> GetAll(string filterString);
        ReaderDto GetById(int readerId);
        bool Add(ReaderDto readerDto);
        bool Delete(int readerId);
    }
}
