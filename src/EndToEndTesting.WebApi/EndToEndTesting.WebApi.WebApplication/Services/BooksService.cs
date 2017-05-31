using EndToEndTesting.WebApi.WebApplication.Models;
using EndToEndTesting.WebApi.WebApplication.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EndToEndTesting.WebApi.WebApplication.Services
{
    public class BooksService : IBooksService
    {
        private readonly IBooksRepository _repository;
        private readonly IDealsService _dealsService;

        public BooksService(IBooksRepository repository, IDealsService dealsService)
        {
            _repository = repository;
            _dealsService = dealsService;
        }

        public IEnumerable<Book> GetAll()
        {
            var books = _repository.GetAll().ToList();
            var deals = _dealsService.GetByBookId(books.Select(x => x.Id));

            foreach (var book in books)
            {
                if (deals.ContainsKey(book.Id))
                {
                    book.AvailableDeals = deals[book.Id];
                }
                else
                {
                    book.AvailableDeals = Enumerable.Empty<Deal>();
                }
            }

            return books;
        }
    }
}