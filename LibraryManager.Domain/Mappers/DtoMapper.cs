using AutoMapper;

namespace LibraryManager.Domain
{
    public class DtoMapper
    {
        private IMapper _mapper;

        public DtoMapper()
        {
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<BookEntity, BookDto>().ReverseMap();
                config.CreateMap<AuthorEntity, AuthorDto>().ReverseMap();
                config.CreateMap<BorrowEntity, BorrowDto>().ReverseMap();
                config.CreateMap<ReaderEntity, ReaderDto>().ReverseMap();
            }).CreateMapper();
        }

        public BookDto Map(BookEntity book) => _mapper.Map<BookDto>(book); //BookEntity -> BookDto
        public List<BookDto> Map(List<BookEntity> books) => _mapper.Map<List<BookDto>>(books); //Collection of BookEntity -> collection of BookDto

        public BookEntity Map(BookDto book) => _mapper.Map<BookEntity>(book); //BookDto -> BookEntity
        public List<BookEntity> Map(List<BookDto> books) => _mapper.Map<List<BookEntity>>(books); //Collection of BookDto -> collection of BookEntity

        public AuthorDto Map(AuthorEntity Author) => _mapper.Map<AuthorDto>(Author); //AuthorEntity -> AuthorDto
        public List<AuthorDto> Map(List<AuthorEntity> Authors) => _mapper.Map<List<AuthorDto>>(Authors); //Collection of AuthorEntity -> collection of AuthorDto

        public AuthorEntity Map(AuthorDto Author) => _mapper.Map<AuthorEntity>(Author); //AuthorDto -> AuthorEntity
        public List<AuthorEntity> Map(List<AuthorDto> Authors) => _mapper.Map<List<AuthorEntity>>(Authors); //Collection of AuthorDto -> collection of AuthorEntity

        public BorrowDto Map(BorrowEntity Borrow) => _mapper.Map<BorrowDto>(Borrow); //BorrowEntity -> BorrowDto
        public List<BorrowDto> Map(List<BorrowEntity> Borrows) => _mapper.Map<List<BorrowDto>>(Borrows); //Collection of BorrowEntity -> collection of BorrowDto

        public BorrowEntity Map(BorrowDto Borrow) => _mapper.Map<BorrowEntity>(Borrow); //BorrowDto -> BorrowEntity
        public List<BorrowEntity> Map(List<BorrowDto> Borrows) => _mapper.Map<List<BorrowEntity>>(Borrows); //Collection of BorrowDto -> collection of BorrowEntity

        public ReaderDto Map(ReaderEntity Reader) => _mapper.Map<ReaderDto>(Reader); //ReaderEntity -> ReaderDto
        public List<ReaderDto> Map(List<ReaderEntity> Readers) => _mapper.Map<List<ReaderDto>>(Readers); //Collection of ReaderEntity -> collection of ReaderDto

        public ReaderEntity Map(ReaderDto Reader) => _mapper.Map<ReaderEntity>(Reader); //ReaderDto -> ReaderEntity
        public List<ReaderEntity> Map(List<ReaderDto> Readers) => _mapper.Map<List<ReaderEntity>>(Readers); //Collection of ReaderDto -> collection of ReaderEntity
    }
       
}
