namespace LibraryManager.Domain
{ 
    public class BookManager : IBookManager
    {
        private readonly IBookRepository _bookRepository;
        private readonly BookMapper _mapper;

        public BookManager(IBookRepository bookRepository, BookMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public IEnumerable<BookDto> GetAll(string filterString, bool borrowedOnly) //filterString is book title written in search box.
        {
            var bookEntities = _bookRepository.GetAll();

            if(borrowedOnly)
            {
                bookEntities = bookEntities.Where(x => x.IsBorrowed);
            }

            if (!string.IsNullOrEmpty(filterString))
            {
                bookEntities = bookEntities.Where(x => x.Title.Contains(filterString));
            }

            return _mapper.Map(bookEntities);
        }
        public bool Add(BookDto bookDto)
        {
            var bookEntity = _mapper.Map(bookDto);
            return _bookRepository.Add(bookEntity);
        }

        public bool Delete(BookDto bookDto)
        {
            var bookEntity = _mapper.Map(bookDto);
            return _bookRepository.Delete(bookEntity);
        }
    }
}
