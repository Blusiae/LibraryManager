using AutoMapper;
using LibraryManager.Domain;

namespace LibraryManager
{
    public class BorrowDtoMapper
    {
        private IMapper _mapper;

        public BorrowDtoMapper()
        {
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<BorrowDto, BorrowViewModel>().ReverseMap();
            }).CreateMapper();
        }

        public BorrowViewModel Map(BorrowDto borrow) => _mapper.Map<BorrowViewModel>(borrow); //BorrowDto -> BorrowViewModel
        public IEnumerable<BorrowViewModel> Map(IEnumerable<BorrowDto> borrows) => _mapper.Map<IEnumerable<BorrowViewModel>>(borrows); //Collection of BorrowDto -> collection of BorrowViewModel

        public BorrowDto Map(BorrowViewModel borrow) => _mapper.Map<BorrowDto>(borrow); //BorrowViewModel -> BorrowDto
        public IEnumerable<BorrowDto> Map(IEnumerable<BorrowViewModel> borrows) => _mapper.Map<IEnumerable<BorrowDto>>(borrows); //Collection of BorrowViewModel -> collection of BorrowDto

    }
}
