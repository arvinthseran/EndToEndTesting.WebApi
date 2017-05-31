using EndToEndTesting.WebApi.WebApplication.Models;
using System.Collections.Generic;
using System;
using EndToEndTesting.WebApi.WebApplication.Repositories;

namespace EndToEndTesting.WebApi.WebApplication.Services
{
    public interface IDealsService
    {
        Dictionary<int, string> GetByBookId(IEnumerable<int> enumerable);
    }
}