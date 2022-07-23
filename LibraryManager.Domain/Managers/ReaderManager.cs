namespace LibraryManager.Domain
{
    public class ReaderManager : IReaderManager
    {
        private readonly IReaderRepository _readerRepository;
        private readonly DtoMapper _mapper;

        public ReaderManager(IReaderRepository readerRepository, DtoMapper mapper)
        {
            _readerRepository = readerRepository;
            _mapper = mapper;
        }

        public List<ReaderDto> GetAll(string filterString) //filterString is firstname or lastname written in search box.
        {
            var readerEntities = _readerRepository.GetAll().ToList();

            if(!string.IsNullOrEmpty(filterString))
            {
                readerEntities = readerEntities.Where(x => x.FirstName.Contains(filterString) || x.LastName.Contains(filterString)).ToList();
            }

            return _mapper.Map(readerEntities);
        }

        public ReaderDto GetById(int readerId)
        {
            var readeryEntity = _readerRepository.GetById(readerId);
            return _mapper.Map(readeryEntity);
        }

        public bool Add(ReaderDto readerDto)
        {
            if (string.IsNullOrEmpty(readerDto.FirstName) || string.IsNullOrEmpty(readerDto.LastName))
            {
                return false;
            }

            var readerEntity = _mapper.Map(readerDto);
            return _readerRepository.Add(readerEntity);
        }

        public bool Delete(int readerId)
        {
            return _readerRepository.Delete(readerId);
        }
    }
}
