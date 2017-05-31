using EndToEndTesting.WebApi.WebApplication.Models;
using System.Collections.Generic;

namespace EndToEndTesting.WebApi.WebApplication.Services
{
    public interface IBooksService
    {
        IEnumerable<Book> GetAll();
    }
}