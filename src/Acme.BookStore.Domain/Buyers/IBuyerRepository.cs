using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Acme.BookStore.Authors;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Buyers;

public interface IBuyerRepository : IRepository<Buyers,Guid>
{
    Task<Buyers> FindByNameAsync(string name);

    Task<List<Buyers>> GetListAsync(int skipcount, int maxResultCount, string sorting, string filter = null);
}