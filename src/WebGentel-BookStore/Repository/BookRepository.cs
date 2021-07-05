using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentel_BookStore.Data;
using WebGentel_BookStore.Models;

namespace WebGentel_BookStore.Repository
{
    public class BookRepository
    {
        private readonly BookStoreContext _bookStoreContext;
        public BookRepository(BookStoreContext bookStoreContext)
        {
            _bookStoreContext = bookStoreContext;
        }
        public async Task<int> AddNewBook(BookModel bookModel)
        {
            Book book = new Book
            {
                Author = bookModel.Author,
                CreatedOn = DateTime.UtcNow,
                Description = bookModel.Description,
                Title = bookModel.Title,
                TotalPages = bookModel.TotalPages.HasValue ? bookModel.TotalPages.Value : 0,
                UpdatedOn = DateTime.UtcNow
            };

            await _bookStoreContext.Books.AddAsync(book);
            await _bookStoreContext.SaveChangesAsync();
            return book.Id;
        }
        public async Task<List<BookModel>> GetAllBook()
        {
            List<BookModel> books = null;
            books = await (from book in _bookStoreContext.Books
                           select new BookModel
                           {
                               Author = book.Author,
                               Category = book.Category,
                               Description = book.Description,
                               Id = book.Id,
                               Language = book.Language,
                               Title = book.Title,
                               TotalPages = book.TotalPages
                           }).ToListAsync();
            return books;
        }
        public async Task<BookModel> GetBookById(int id)
        {
            BookModel bookDetails = null;
            bookDetails = await (from book in _bookStoreContext.Books
                                 where book.Id == id
                                 select new BookModel
                                 {
                                     Author = book.Author,
                                     Category = book.Category,
                                     Description = book.Description,
                                     Id = book.Id,
                                     Language = book.Language,
                                     Title = book.Title,
                                     TotalPages = book.TotalPages
                                 }).FirstOrDefaultAsync();
            return bookDetails;
        }
        public async Task<List<BookModel>> SearchBook(string title, string authorName)
        {
            List<BookModel> books = null;
            await _bookStoreContext.Books.Where(x => x.Title.Contains(title, StringComparison.InvariantCultureIgnoreCase) ||
                                      x.Author.Contains(authorName, StringComparison.InvariantCultureIgnoreCase)).Select(book => new BookModel
                                      {
                                          Author = book.Author,
                                          Category = book.Category,
                                          Description = book.Description,
                                          Id = book.Id,
                                          Language = book.Language,
                                          Title = book.Title,
                                          TotalPages = book.TotalPages
                                      }).ToListAsync();
            return books;
        }
    }
}
