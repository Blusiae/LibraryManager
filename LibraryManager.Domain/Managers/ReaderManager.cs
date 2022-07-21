namespace LibraryManager.Domain
{
    public class ReaderManager : IReaderManager
    {
        private readonly IReaderRepository _readerRepository;
        private readonly ReaderMapper _mapper;

        public ReaderManager(IReaderRepository readerRepository, ReaderMapper mapper)
        {
            _readerRepository = readerRepository;
            _mapper = mapper;
        }

        public IEnumerable<ReaderDto> GetAll(string filterString) //filterString is firstname or lastname written in search box.
        {
            var readerEntities = _readerRepository.GetAll();

            if(!string.IsNullOrEmpty(filterString))
            {
                readerEntities = readerEntities.Where(x => x.FirstName.Contains(filterString) || x.LastName.Contains(filterString));
            }

            return _mapper.Map(readerEntities);
        }

        public bool Add(ReaderDto readerDto)
        {
            var readerEntity = _mapper.Map(readerDto);
            return _readerRepository.Add(readerEntity);
        }

        public bool Delete(ReaderDto readerDto)
        {
            var readerEntity = _mapper.Map(readerDto);
            return _readerRepository.Delete(readerEntity);
        }
    }
}
