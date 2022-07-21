using AutoMapper;

namespace LibraryManager.Domain
{
    public class ReaderMapper
    {
        private IMapper _mapper;

        public ReaderMapper()
        {
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<ReaderEntity, ReaderDto>().ReverseMap();
            }).CreateMapper();
        }

        public ReaderDto Map(ReaderEntity Reader) => _mapper.Map<ReaderDto>(Reader); //ReaderEntity -> ReaderDto
        public IEnumerable<ReaderDto> Map(IEnumerable<ReaderEntity> Readers) => _mapper.Map<IEnumerable<ReaderDto>>(Readers); //Collection of ReaderEntity -> collection of ReaderDto
        
        public ReaderEntity Map(ReaderDto Reader) => _mapper.Map<ReaderEntity>(Reader); //ReaderDto -> ReaderEntity
        public IEnumerable<ReaderEntity> Map(IEnumerable<ReaderDto> Readers) => _mapper.Map<IEnumerable<ReaderEntity>>(Readers); //Collection of ReaderDto -> collection of ReaderEntity
    }
}
