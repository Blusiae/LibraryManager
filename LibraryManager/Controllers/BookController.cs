using LibraryManager.Domain;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManager
{
    public class BookController : Controller
    {
        private IBookManager _bookManager;
        private ViewModelMapper _mapper;

        public BookController(IBookManager bookManager, ViewModelMapper mapper)
        {
            _bookManager = bookManager;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(string filterString, bool borrowedOnly = false)
        {
            var bookDtos = _bookManager.GetAll(filterString, borrowedOnly);
            var books = _mapper.Map(bookDtos);
            return View(books);
        }
    }
}
