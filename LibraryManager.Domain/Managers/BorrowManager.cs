namespace LibraryManager.Domain
{
    public class BorrowManager : IBorrowManager
    {
        private readonly IBorrowRepository _borrowRepository;
        private readonly DtoMapper _mapper;

        public BorrowManager(IBorrowRepository borrowRepository, DtoMapper borrowMapper)
        {
            _borrowRepository = borrowRepository;
            _mapper = borrowMapper;
        }

        public List<BorrowDto> GetAll()
        {
            var borrowEntities = _borrowRepository.GetAll().ToList();
            return _mapper.Map(borrowEntities);
        }

        public List<BorrowDto> GetBorrowsByBookId(int bookId)
        {
            var borrowEntities = _borrowRepository.GetAll().Where(x => x.BookId == bookId).ToList();
            return _mapper.Map(borrowEntities);
        }

        public List<BorrowDto> GetBorrowsByReaderId(int readerId)
        {
            var borrowEntities = _borrowRepository.GetAll().Where(x => x.ReaderId == readerId).ToList();
            return _mapper.Map(borrowEntities);
        }

        public List<BorrowDto> GetAllCurrentBorrows()
        {
            var borrowEntities = _borrowRepository.GetAll().Where(x => !x.IsReturned).ToList();
            return _mapper.Map(borrowEntities);
        }

        public bool Add(BorrowDto borrowDto)
        {
            var borrowEntity = _mapper.Map(borrowDto);
            return _borrowRepository.Add(borrowEntity);
        }
    }
}
