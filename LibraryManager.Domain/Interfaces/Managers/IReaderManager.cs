namespace LibraryManager.Domain
{
    public interface IReaderManager
    {
        List<ReaderDto> GetAll(string filterString);
        bool Add(ReaderDto readerDto);
        bool Delete(int readerId);
    }
}
