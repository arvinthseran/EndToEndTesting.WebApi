using EndToEndTesting.WebApi.WebApplication.Models;
using System.Collections.Generic;
using System.Linq;

namespace EndToEndTesting.WebApi.WebApplication.Repositories
{
    public class DealsRepository : IDealsRepository
    {
        private readonly IEnumerable<Deal> _deals = new[]
        {
            new Deal { Id = 11, BookId = 1, Title = "Development" ,message = "Buy 2 for 1"},
            new Deal { Id = 12, BookId = 2, Title = "Testing", message = "Half price" }
        };

        public Dictionary<int, string> GetByBookId(IEnumerable<int> enumerable)
        {
            Dictionary<int, string> result = new Dictionary<int, string>();
            foreach (var enumerables in enumerable)
            {
                var deal = _deals.First(x => x.BookId == enumerables);
                result.Add(deal.BookId, deal.Title);
            }

            return result;
        }
    }
}