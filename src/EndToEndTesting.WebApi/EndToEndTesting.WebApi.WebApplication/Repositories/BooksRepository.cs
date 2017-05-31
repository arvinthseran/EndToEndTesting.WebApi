using System.Collections.Generic;
using EndToEndTesting.WebApi.WebApplication.Models;

namespace EndToEndTesting.WebApi.WebApplication.Repositories
{
    public class BooksRepository : IBooksRepository
    {
        private readonly IEnumerable<Book> _books = new[] { new Book {Id = 1, Title = "Development"  }, new Book { Id = 2, Title = "Testing" } };
        public IEnumerable<Book> GetAll()
        {
            return _books;
        }
    }
}