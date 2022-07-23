using LibraryManager.Domain;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManager
{
    public class BorrowController : Controller
    {
        private IBorrowManager _borrowManager;
        private ViewModelMapper _mapper;

        public BorrowController(IBorrowManager borrowManager, ViewModelMapper mapper)
        {
            _borrowManager = borrowManager;
            _mapper = mapper;
        }

        public IActionResult List()
        {
            var borrowDtos = _borrowManager.GetAllCurrentBorrows();
            var borrows = _mapper.Map(borrowDtos);

            return View(borrows);
        }
    }
}
