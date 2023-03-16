using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Linq;

namespace Acme.BookStore.Books;

public class IBookRepository : IRepository<BookDto,Guid>
{
    public Task<List<BookDto>> GetListAsync(bool includeDetails = false, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task<long> GetCountAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task<List<BookDto>> GetPagedListAsync(int skipCount, int maxResultCount, string sorting, bool includeDetails = false,
        CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public IQueryable<BookDto> WithDetails()
    {
        throw new NotImplementedException();
    }

    public IQueryable<BookDto> WithDetails(params Expression<Func<BookDto, object>>[] propertySelectors)
    {
        throw new NotImplementedException();
    }

    public Task<IQueryable<BookDto>> WithDetailsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IQueryable<BookDto>> WithDetailsAsync(params Expression<Func<BookDto, object>>[] propertySelectors)
    {
        throw new NotImplementedException();
    }

    public Task<IQueryable<BookDto>> GetQueryableAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<BookDto>> GetListAsync(Expression<Func<BookDto, bool>> predicate, bool includeDetails = false,
        CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public IAsyncQueryableExecuter AsyncExecuter { get; }
    public Task<BookDto> InsertAsync(BookDto entity, bool autoSave = false, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task InsertManyAsync(IEnumerable<BookDto> entities, bool autoSave = false,
        CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task<BookDto> UpdateAsync(BookDto entity, bool autoSave = false, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task UpdateManyAsync(IEnumerable<BookDto> entities, bool autoSave = false,
        CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(BookDto entity, bool autoSave = false, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task DeleteManyAsync(IEnumerable<BookDto> entities, bool autoSave = false,
        CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task<BookDto> FindAsync(Expression<Func<BookDto, bool>> predicate, bool includeDetails = true,
        CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task<BookDto> GetAsync(Expression<Func<BookDto, bool>> predicate, bool includeDetails = true,
        CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Expression<Func<BookDto, bool>> predicate, bool autoSave = false,
        CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public async Task<BookDto> GetAsync(Guid id, bool includeDetails = true, CancellationToken cancellationToken = new CancellationToken())
    {
        var book = await GetAsync(id);
        return book;
    }

    public Task<BookDto> FindAsync(Guid id, bool includeDetails = true, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id, bool autoSave = false, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public Task DeleteManyAsync(IEnumerable<Guid> ids, bool autoSave = false,
        CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }
}