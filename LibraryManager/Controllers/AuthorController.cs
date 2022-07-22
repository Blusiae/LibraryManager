using LibraryManager.Domain;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManager
{
    public class AuthorController : Controller
    {
        private IAuthorManager _authorManager;
        private ViewModelMapper _mapper;

        public AuthorController(IAuthorManager authorManager, ViewModelMapper mapper)
        {
            _authorManager = authorManager;
            _mapper = mapper;
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
    }
}
