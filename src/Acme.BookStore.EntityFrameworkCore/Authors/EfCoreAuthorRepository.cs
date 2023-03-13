using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Acme.BookStore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace Acme.BookStore.Authors;

public class EfCoreAuthorRepository : EfCoreRepository<BookStoreDbContext,Author,Guid>,IAuthorRepository
{
    public EfCoreAuthorRepository(IDbContextProvider<BookStoreDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public async Task<Author> FindByNameAsync(string name)
    {
        var dbset = await GetDbSetAsync();
        return await dbset.FirstOrDefaultAsync(Author => Author.Name == name);
    }

    public async Task<List<Author>> GetListAsync(int skipcount, int maxResultCount, string sorting, string filter = null)
    {
        var dbset = await GetDbSetAsync();
        return dbset
            .WhereIf(!filter.IsNullOrWhiteSpace(), author => author.Name.Contains(filter)).OrderBy(sorting)
            .Skip(skipcount).Take(maxResultCount).ToList();

    }
}