using LibraryManager.Domain;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManager
{
    public class AuthorController : Controller
    {
        private IAuthorManager _authorManager;
        private IBookManager _bookManager;
        private ViewModelMapper _mapper;

        public AuthorController(IAuthorManager authorManager, ViewModelMapper mapper, IBookManager bookManager)
        {
            _authorManager = authorManager;
            _mapper = mapper;
            _bookManager = bookManager;
        }

        public IActionResult Add(bool failInformation = false)
        {
            ViewData["failInformation"] = failInformation;
            return View();
        }

        [HttpPost]
        public IActionResult Add(AuthorViewModel author)
        {
            var authorDto = _mapper.Map(author);

            if(_authorManager.Add(authorDto))
            {
                return RedirectToAction("Add", "Book");
            }

            return RedirectToAction("Add", new {failInformation = true});
        }

        public IActionResult List(bool authorHasBooksInfo = false)
        {
            var authorDtos = _authorManager.GetAll();
            var authors = _mapper.Map(authorDtos);
            authors.ForEach(x => x.BooksCount = _bookManager.GetBooksCountByAuthorId(x.Id));
            ViewData["AuthorHasBooksInfo"] = authorHasBooksInfo;
            return View(authors);
        }

        public IActionResult Delete(int authorId)
        {
            if(_bookManager.GetBooksCountByAuthorId(authorId) > 0)
            {
                return RedirectToAction("List", new { authorHasBooksInfo = true });
            }
            _authorManager.Delete(authorId);

            return RedirectToAction("List");
        }
    }
}
