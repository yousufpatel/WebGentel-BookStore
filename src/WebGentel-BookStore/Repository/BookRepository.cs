using System;
using System.Collections.Generic;
using System.Linq;
using WebGentel_BookStore.Models;

namespace WebGentel_BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBook()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => { return x.Id == 1; }).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title, StringComparison.InvariantCultureIgnoreCase) ||
                                      x.Author.Contains(authorName, StringComparison.InvariantCultureIgnoreCase)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>
            {
                new BookModel { Id =  1, Author = "Yousuf", Title = "MVC"},
                new BookModel { Id = 2, Author = "Umar", Title = "C#"},
                new BookModel { Id = 3, Author = "Patel",Title ="Php"},
                new BookModel {Id = 4,Author = "Peter",Title = "java"},
                new BookModel { Id = 5,Author = "Will",Title = "Dot Net Core"}

            };
        }
    }
}
