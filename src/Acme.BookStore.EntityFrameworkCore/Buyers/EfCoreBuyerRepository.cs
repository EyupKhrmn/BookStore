using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Acme.BookStore.Authors;
using Acme.BookStore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Acme.BookStore.Buyers;

public class EfCoreBuyerRepository : EfCoreRepository<BookStoreDbContext,Buyers,Guid>,IBuyerRepository
{
    public EfCoreBuyerRepository(IDbContextProvider<BookStoreDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public async Task<Buyers> FindByNameAsync(string name)
    {
        var buyer = await GetDbSetAsync();
        return await buyer.FirstOrDefaultAsync(buyer => buyer.Name == name);
    }

    public Task<List<Buyers>> GetListAsync(int skipcount, int maxResultCount, string sorting, string filter = null)
    {
        throw new NotImplementedException();
    }
}