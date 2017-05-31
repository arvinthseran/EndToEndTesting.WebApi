using System.Web.Http;
using EndToEndTesting.WebApi.WebApplication.Services;

namespace EndToEndTesting.WebApi.WebApplication.Controllers
{
    public class BooksController : ApiController
    {
        private readonly IBooksService _booksService;

        public BooksController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        [Route]
        public IHttpActionResult Get()
        {
            return Ok(_booksService.GetAll());
        }
    }
}