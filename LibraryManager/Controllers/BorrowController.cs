using LibraryManager.Domain;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManager
{
    public class BorrowController : Controller
    {
        private IBorrowManager _borrowManager;
        private IBookManager _bookManager;
        private IReaderManager _readerManager;
        private ViewModelMapper _mapper;

        public BorrowController(IBorrowManager borrowManager, IBookManager bookManager, IReaderManager readerManager, ViewModelMapper mapper)
        {
            _borrowManager = borrowManager;
            _bookManager = bookManager;
            _readerManager = readerManager;
            _mapper = mapper;
        }

        public IActionResult Add()
        {
            var bookDtos = _bookManager.GetAll(string.Empty, false, true);
            ViewData["Books"] = _mapper.Map(bookDtos);
            var readerDtos = _readerManager.GetAll(string.Empty);
            ViewData["Readers"] = _mapper.Map(readerDtos);
            return View();
        }

        [HttpPost]
        public IActionResult Add(BorrowViewModel borrow, int bookId, int readerId)
        {
            borrow.ReturnDeadline = borrow.BorrowDate.AddMonths(1);
            var borrowDto = _mapper.Map(borrow);
            _borrowManager.Add(borrowDto, bookId, readerId);

            return RedirectToAction("List");
        }
        public IActionResult List()
        {
            var borrowDtos = _borrowManager.GetAllCurrentBorrows();
            var borrows = _mapper.Map(borrowDtos);

            return View(borrows);
        }

        public IActionResult Delete(int borrowId, int bookId)
        {
            _borrowManager.Delete(borrowId, bookId);

            return RedirectToAction("List");
        }

        public IActionResult BookReturn(int borrowId, int bookId)
        {
            _borrowManager.BookReturn(borrowId, bookId);
            return RedirectToAction("List");
        }
    }
}
