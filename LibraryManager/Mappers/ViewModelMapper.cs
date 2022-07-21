using AutoMapper;
using LibraryManager.Domain;

namespace LibraryManager
{
    public class ViewModelMapper
    {
        private IMapper _mapper;

        public ViewModelMapper()
        {
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<BookDto, BookViewModel>().ReverseMap();
                config.CreateMap<ReaderDto, ReaderViewModel>().ReverseMap();
                config.CreateMap<BorrowDto, BorrowViewModel>().ReverseMap();
                config.CreateMap<AuthorDto, AuthorViewModel>().ReverseMap();
            }).CreateMapper();
        }

        public BookViewModel Map(BookDto book) => _mapper.Map<BookViewModel>(book); //BookDto -> BookViewModel
        public List<BookViewModel> Map(List<BookDto> books) => _mapper.Map<List<BookViewModel>>(books); //Collection of BookDto -> collection of BookViewModel

        public BookDto Map(BookViewModel book) => _mapper.Map<BookDto>(book); //BookViewModel -> BookDto
        public List<BookDto> Map(List<BookViewModel> books) => _mapper.Map<List<BookDto>>(books); //Collection of BookViewModel -> collection of BookDto

        public ReaderViewModel Map(ReaderDto reader) => _mapper.Map<ReaderViewModel>(reader); //ReaderDto -> ReaderViewModel
        public List<ReaderViewModel> Map(List<ReaderDto> readers) => _mapper.Map<List<ReaderViewModel>>(readers); //Collection of ReaderDto -> collection of ReaderViewModel

        public ReaderDto Map(ReaderViewModel reader) => _mapper.Map<ReaderDto>(reader); //ReaderViewModel -> ReaderDto
        public List<ReaderDto> Map(List<ReaderViewModel> readers) => _mapper.Map<List<ReaderDto>>(readers); //Collection of ReaderViewModel -> collection of ReaderDto

        public BorrowViewModel Map(BorrowDto borrow) => _mapper.Map<BorrowViewModel>(borrow); //BorrowDto -> BorrowViewModel
        public List<BorrowViewModel> Map(List<BorrowDto> borrows) => _mapper.Map<List<BorrowViewModel>>(borrows); //Collection of BorrowDto -> collection of BorrowViewModel

        public BorrowDto Map(BorrowViewModel borrow) => _mapper.Map<BorrowDto>(borrow); //BorrowViewModel -> BorrowDto
        public List<BorrowDto> Map(List<BorrowViewModel> borrows) => _mapper.Map<List<BorrowDto>>(borrows); //Collection of BorrowViewModel -> collection of BorrowDto

        public AuthorViewModel Map(AuthorDto author) => _mapper.Map<AuthorViewModel>(author); //AuthorDto -> AuthorViewModel
        public List<AuthorViewModel> Map(List<AuthorDto> authors) => _mapper.Map<List<AuthorViewModel>>(authors); //Collection of AuthorDto -> collection of AuthorViewModel

        public AuthorDto Map(AuthorViewModel author) => _mapper.Map<AuthorDto>(author); //AuthorViewModel -> AuthorDto
        public List<AuthorDto> Map(List<AuthorViewModel> authors) => _mapper.Map<List<AuthorDto>>(authors); //Collection of AuthorViewModel -> collection of AuthorDto

    }
}
