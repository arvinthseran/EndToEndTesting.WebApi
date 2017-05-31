
namespace EndToEndTesting.WebApi.WebApplication.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int DealsCount { get; set; }
        public object AvailableDeals { get; internal set; }
    }
}