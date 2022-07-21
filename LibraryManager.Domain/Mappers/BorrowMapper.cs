using AutoMapper;

namespace LibraryManager.Domain
{
    public class BorrowMapper
    {
        private IMapper _mapper;

        public BorrowMapper()
        {
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<BorrowEntity, BorrowDto>().ReverseMap();
            }).CreateMapper();
        }

        public BorrowDto Map(BorrowEntity Borrow) => _mapper.Map<BorrowDto>(Borrow); //BorrowEntity -> BorrowDto
        public IEnumerable<BorrowDto> Map(IEnumerable<BorrowEntity> Borrows) => _mapper.Map<IEnumerable<BorrowDto>>(Borrows); //Collection of BorrowEntity -> collection of BorrowDto
        
        public BorrowEntity Map(BorrowDto Borrow) => _mapper.Map<BorrowEntity>(Borrow); //BorrowDto -> BorrowEntity
        public IEnumerable<BorrowEntity> Map(IEnumerable<BorrowDto> Borrows) => _mapper.Map<IEnumerable<BorrowEntity>>(Borrows); //Collection of BorrowDto -> collection of BorrowEntity
    }
}
