namespace LibraryManager.Domain
{
    public class BorrowManager : IBorrowManager
    {
        private readonly IBorrowRepository _borrowRepository;
        private readonly BorrowMapper _mapper;

        public BorrowManager(IBorrowRepository borrowRepository, BorrowMapper borrowMapper)
        {
            _borrowRepository = borrowRepository;
            _mapper = borrowMapper;
        }

        public IEnumerable<BorrowDto> GetAll()
        {
            var borrowEntities = _borrowRepository.GetAll();
            return _mapper.Map(borrowEntities);
        }

        public bool Add(BorrowDto borrowDto)
        {
            var borrowEntity = _mapper.Map(borrowDto);
            return _borrowRepository.Add(borrowEntity);
        }
    }
}
