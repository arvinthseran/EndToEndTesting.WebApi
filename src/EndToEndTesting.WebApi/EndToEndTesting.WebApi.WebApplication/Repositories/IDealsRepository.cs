using System.Collections.Generic;

namespace EndToEndTesting.WebApi.WebApplication.Repositories
{
    public interface IDealsRepository
    {
        Dictionary<int, string> GetByBookId(IEnumerable<int> enumerable);
    }
}