namespace BookstoreAPI.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using BookstoreAPI.Models;

    public class BookRepository : IBookRepository
    {
        private readonly List<Book> books = new List<Book>
    {
        new Book { Id = 1, Title = "C# Fundamentals", Author = "John Doe", Category = "Programming", Price = 29.99M },
        new Book { Id = 2, Title = "ASP.NET Core Guide", Author = "Jane Smith", Category = "Web Development", Price = 35.99M },
    };

        public IEnumerable<Book> GetAllBooks() => books;

        public Book GetBookById(int id) => books.FirstOrDefault(book => book.Id == id);
    }

}
