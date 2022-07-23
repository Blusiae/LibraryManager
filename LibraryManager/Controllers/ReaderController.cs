using LibraryManager.Domain;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManager
{
    public class ReaderController : Controller
    {
        private IReaderManager _readerManager;
        private IBorrowManager _borrowManager;
        private ViewModelMapper _mapper;

        public ReaderController(IReaderManager readerManager, IBorrowManager borrowManager, ViewModelMapper mapper)
        {
            _readerManager = readerManager;
            _borrowManager = borrowManager;
            _mapper = mapper;
        }

        public IActionResult Index(int readerId)
        {
            var readerDto = _readerManager.GetById(readerId);
            var reader = _mapper.Map(readerDto);
            var borrowDtos = _borrowManager.GetBorrowsByReaderId(readerId);
            ViewData["Borrows"] = _mapper.Map(borrowDtos);
            return View(reader);
        }

        public IActionResult List(string filterString)
        {
            var readerDtos = _readerManager.GetAll(filterString);
            var readers = _mapper.Map(readerDtos);
            return View(readers);
        }

        public IActionResult Add(bool failInformation = false)
        {
            ViewData["failInformation"] = failInformation;
            return View();
        }

        [HttpPost]
        public IActionResult Add(ReaderViewModel reader)
        {
            var readerDto = _mapper.Map(reader);
            if (_readerManager.Add(readerDto))
            {
                return RedirectToAction("List");
            }

            return RedirectToAction("Add", new { failInformation = true });
        }

        public IActionResult Delete(int readerId)
        {
            var readerDto = _readerManager.GetById(readerId);
            var reader = _mapper.Map(readerDto);
            return View(reader);
        }

        public IActionResult DeleteReader(int readerId)
        {
            _readerManager.Delete(readerId);
            return RedirectToAction("List");
        }
    }
}
