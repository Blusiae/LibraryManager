namespace LibraryManager.Domain
{ 
    public class AuthorManager : IAuthorManager
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly AuthorMapper _mapper;

        public AuthorManager(IAuthorRepository authorRepository, AuthorMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }
        public bool Add(AuthorDto authorDto)
        {
            var authorEntity = _mapper.Map(authorDto);
            return _authorRepository.Add(authorEntity);
        }
    }
}
