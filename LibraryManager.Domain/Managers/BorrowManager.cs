namespace LibraryManager.Domain
{
    public class BorrowManager : IBorrowManager
    {
        private readonly IBorrowRepository _borrowRepository;
        private readonly IBookManager _bookManager;
        private readonly DtoMapper _mapper;

        public BorrowManager(IBorrowRepository borrowRepository, IBookManager bookManager, DtoMapper borrowMapper)
        {
            _borrowRepository = borrowRepository;
            _bookManager = bookManager;
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

        public bool Add(BorrowDto borrowDto, int bookId, int readerId)
        {
            var borrowEntity = _mapper.Map(borrowDto);
            borrowEntity.BookId = bookId;
            borrowEntity.ReaderId = readerId;
            if(!_bookManager.Borrow(bookId))
            {
                return false;
            }
            return _borrowRepository.Add(borrowEntity);
        }

        public bool Delete(int borrowId, int bookId)
        {
            if(!_bookManager.Unborrow(bookId))
            {
                return false;
            }

            return _borrowRepository.Delete(borrowId);
        }

        public bool BookReturn(int borrowId, int bookId)
        {
            if (!_bookManager.Unborrow(bookId))
            {
                return false;
            }

            return _borrowRepository.Return(borrowId);
        }
    }
}
