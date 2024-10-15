namespace BookstoreAPI.Repositories
{
    using System.Collections.Generic;
    using BookstoreAPI.Models;

    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int id);
    }
}
