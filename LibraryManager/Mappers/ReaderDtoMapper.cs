using AutoMapper;
using LibraryManager.Domain;

namespace LibraryManager
{
    public class ReaderDtoMapper
    {
        private IMapper _mapper;

        public ReaderDtoMapper()
        {
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<ReaderDto, ReaderViewModel>().ReverseMap();
            }).CreateMapper();
        }

        public ReaderViewModel Map(ReaderDto reader) => _mapper.Map<ReaderViewModel>(reader); //ReaderDto -> ReaderViewModel
        public IEnumerable<ReaderViewModel> Map(IEnumerable<ReaderDto> readers) => _mapper.Map<IEnumerable<ReaderViewModel>>(readers); //Collection of ReaderDto -> collection of ReaderViewModel

        public ReaderDto Map(ReaderViewModel reader) => _mapper.Map<ReaderDto>(reader); //ReaderViewModel -> ReaderDto
        public IEnumerable<ReaderDto> Map(IEnumerable<ReaderViewModel> readers) => _mapper.Map<IEnumerable<ReaderDto>>(readers); //Collection of ReaderViewModel -> collection of ReaderDto

    }
}
