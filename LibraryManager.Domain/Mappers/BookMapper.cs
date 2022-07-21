using AutoMapper;

namespace LibraryManager.Domain
{
    public class BookMapper
    {
        private IMapper _mapper;

        public BookMapper()
        {
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<BookEntity, BookDto>().ReverseMap();
            }).CreateMapper();
        }

        public BookDto Map(BookEntity book) => _mapper.Map<BookDto>(book); //BookEntity -> BookDto
        public IEnumerable<BookDto> Map(IEnumerable<BookEntity> books) => _mapper.Map<IEnumerable<BookDto>>(books); //Collection of BookEntity -> collection of BookDto
        
        public BookEntity Map(BookDto book) => _mapper.Map<BookEntity>(book); //BookDto -> BookEntity
        public IEnumerable<BookEntity> Map(IEnumerable<BookDto> books) => _mapper.Map<IEnumerable<BookEntity>>(books); //Collection of BookDto -> collection of BookEntity
    }
}
