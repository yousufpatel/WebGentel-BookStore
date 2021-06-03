using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentel_BookStore.Models;
using WebGentel_BookStore.Repository;

namespace WebGentel_BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public IActionResult GetAllBooks()
        {
            return Json(_bookRepository.GetAllBook());
        }

        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<BookModel> SearchBookName(string bookName, string autherName)
        {
            return _bookRepository.SearchBook(bookName, autherName);

        }
    }
}
