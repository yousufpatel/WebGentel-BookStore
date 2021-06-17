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
            return DataSource().Where(x => { return x.Id == id; }).FirstOrDefault();
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
                new BookModel { Id =  1, Author = "Yousuf", Title = "MVC",Description = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit",Category = "FrameWork",Language = "English",TotalPages = 134},
                new BookModel { Id = 2, Author = "Umar", Title = "C#",Description = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit",Category = "Programming",Language = "English",TotalPages = 444},
                new BookModel { Id = 3, Author = "Patel",Title ="Php",Description = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit",Category = "Server Side Scripting Language",Language = "English",TotalPages = 222},
                new BookModel {Id = 4,Author = "Peter",Title = "Java",Description = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit",Category = "Programming",Language = "English",TotalPages = 44},
                new BookModel { Id = 5,Author = "Will",Title = "Dot Net Core",Description = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit",Category = "FrameWork",Language = "English",TotalPages = 555},
                new BookModel { Id = 6,Author = "Yousuf",Title = "Azure Admin",Description = "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit",Category = "Microsoft Technologies",Language = "English",TotalPages = 233}

            };
        }
    }
}
