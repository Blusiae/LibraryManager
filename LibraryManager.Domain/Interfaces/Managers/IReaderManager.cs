namespace LibraryManager.Domain
{
    public interface IReaderManager
    {
        IEnumerable<ReaderDto> GetAll(string filterString);
        bool Add(ReaderDto readerDto);
        bool Delete(ReaderDto readerDto);
    }
}
