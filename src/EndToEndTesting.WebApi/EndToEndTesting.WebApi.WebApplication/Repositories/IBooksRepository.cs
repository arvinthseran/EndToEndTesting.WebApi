using EndToEndTesting.WebApi.WebApplication.Models;
using System.Collections.Generic;

namespace EndToEndTesting.WebApi.WebApplication.Repositories
{
    public interface IBooksRepository
    {
        IEnumerable<Book> GetAll();
    }
}