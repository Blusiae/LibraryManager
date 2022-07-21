using AutoMapper;
using LibraryManager.Domain;

namespace LibraryManager
{
    public class BookDtoMapper
    {
        private IMapper _mapper;

        public BookDtoMapper()
        {
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<BookDto, BookViewModel>().ReverseMap();
            }).CreateMapper();
        }

        public BookViewModel Map(BookDto book) => _mapper.Map<BookViewModel>(book); //BookDto -> BookViewModel
        public IEnumerable<BookViewModel> Map(IEnumerable<BookDto> books) => _mapper.Map<IEnumerable<BookViewModel>>(books); //Collection of BookDto -> collection of BookViewModel

        public BookDto Map(BookViewModel book) => _mapper.Map<BookDto>(book); //BookViewModel -> BookDto
        public IEnumerable<BookDto> Map(IEnumerable<BookViewModel> books) => _mapper.Map<IEnumerable<BookDto>>(books); //Collection of BookViewModel -> collection of BookDto

    }
}
