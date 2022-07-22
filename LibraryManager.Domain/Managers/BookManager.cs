namespace LibraryManager.Domain
{ 
    public class BookManager : IBookManager
    {
        private readonly IBookRepository _bookRepository;
        private readonly DtoMapper _mapper;

        public BookManager(IBookRepository bookRepository, DtoMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public List<BookDto> GetAll(string filterString, bool borrowedOnly) //filterString is book title written in search box.
        {
            var bookEntities = _bookRepository.GetAll().ToList();

            if(borrowedOnly)
            {
                bookEntities = bookEntities.Where(x => x.IsBorrowed).ToList();
            }

            if (!string.IsNullOrEmpty(filterString))
            {
                bookEntities = bookEntities.Where(x => x.Title.Contains(filterString)).ToList();
            }

            return _mapper.Map(bookEntities);
        }
        public bool Add(BookDto bookDto, int authorId)
        {
            if (string.IsNullOrEmpty(bookDto.Title) || authorId == 0)
            {
                return false;
            }

            var bookEntity = _mapper.Map(bookDto);
            bookEntity.AuthorId = authorId;
            return _bookRepository.Add(bookEntity);
        }

        public BookDto GetById(int id)
        {
            var bookEntity = _bookRepository.GetById(id);

            return _mapper.Map(bookEntity);
        }

        public bool Delete(BookDto bookDto)
        {
            var bookEntity = _mapper.Map(bookDto);
            return _bookRepository.Delete(bookEntity);
        }
    }
}
