namespace LibraryManager.Domain
{ 
    public class AuthorManager : IAuthorManager
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly DtoMapper _mapper;

        public AuthorManager(IAuthorRepository authorRepository, DtoMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public List<AuthorDto> GetAll()
        {
            var authorEntities = _authorRepository.GetAll().ToList();
            return _mapper.Map(authorEntities);
        }

        public bool Add(AuthorDto authorDto)
        {
            if(string.IsNullOrEmpty(authorDto.FirstName) || string.IsNullOrEmpty(authorDto.LastName))
            {
                return false;
            }
            var authorEntity = _mapper.Map(authorDto);
            return _authorRepository.Add(authorEntity);
        }
    }
}
