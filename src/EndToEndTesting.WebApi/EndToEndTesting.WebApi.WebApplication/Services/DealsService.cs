using EndToEndTesting.WebApi.WebApplication.Repositories;
using System.Collections.Generic;

namespace EndToEndTesting.WebApi.WebApplication.Services
{
    public class DealsService : IDealsService
    {
        private readonly IDealsRepository _repository;
        public DealsService(IDealsRepository repository)
        {
            _repository = repository;
        }

        public Dictionary<int, string> GetByBookId(IEnumerable<int> enumerable)
        {
            return _repository.GetByBookId(enumerable);
        }
    }
}