﻿using LibraryManager.Domain;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManager
{
    public class BookController : Controller
    {
        private IBookManager _bookManager;
        private IAuthorManager _authorManager;
        private ViewModelMapper _mapper;

        public BookController(IBookManager bookManager, IAuthorManager authorManager, ViewModelMapper mapper)
        {
            _bookManager = bookManager;
            _authorManager = authorManager;
            _mapper = mapper;
        }
        public IActionResult Index(int bookId)
        {
            return View(book);
        }

        public IActionResult List(string filterString, bool borrowedOnly = false)
        {
            var bookDtos = _bookManager.GetAll(filterString, borrowedOnly);
            var books = _mapper.Map(bookDtos);
            return View(books);
        }

        public IActionResult Add(bool failInformation = false)
        {
            var authorDtos = _authorManager.GetAll();
            ViewData["Authors"] = _mapper.Map(authorDtos);
            ViewData["failInformation"] = failInformation;
            return View();
        }

        [HttpPost]
        public IActionResult Add(BookViewModel book, int authorId)
        {
            var bookDto = _mapper.Map(book);
            if(_bookManager.Add(bookDto, authorId))
            {
                return RedirectToAction("List");
            }

            return RedirectToAction("Add", new {failInformation = true});
        }
    }
}
