using LibraryManager.Domain;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManager
{
    public class ReaderController : Controller
    {
        private IReaderManager _readerManager;
        private ViewModelMapper _mapper;

        public ReaderController(IReaderManager readerManager, ViewModelMapper mapper)
        {
            _readerManager = readerManager;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(string filterString)
        {
            var readerDtos = _readerManager.GetAll(filterString);
            var readers = _mapper.Map(readerDtos);
            return View(readers);
        }
    }
}
