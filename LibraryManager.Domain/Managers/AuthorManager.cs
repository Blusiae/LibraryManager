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

        public AuthorDto GetAuthorForBook(BookDto book)
        {
            var authorEntities = _authorRepository.GetAll();
            var authorEntity = authorEntities.FirstOrDefault(x => x.Id == book.Author.Id);
            return _mapper.Map(authorEntity);
        }

        public bool Add(AuthorDto authorDto)
        {
            var authorEntity = _mapper.Map(authorDto);
            return _authorRepository.Add(authorEntity);
        }
    }
}
