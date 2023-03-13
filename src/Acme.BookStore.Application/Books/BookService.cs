using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Acme.BookStore.Authors;
using Acme.BookStore.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books;

public class BookService : CrudAppService<Book,BookDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateBookDto>,IBookAppService
{

    private readonly IAuthorRepository _authorRepository;
    public BookService(IRepository<Book, Guid> repository, IAuthorRepository authorRepository) : base(repository)
    {
        _authorRepository = authorRepository;
        GetPolicyName = BookStorePermissions.Books.Default;
        GetListPolicyName = BookStorePermissions.Books.Default;
        CreatePolicyName = BookStorePermissions.Books.Create;
        DeletePolicyName = BookStorePermissions.Books.Delete;
        UpdatePolicyName = BookStorePermissions.Books.Edit;
    }

    public async Task<ListResultDto<AuthorsLookUpDto>> GetAuthorLookUpAsync()
    {
        var authors = await _authorRepository.GetListAsync();

        return new ListResultDto<AuthorsLookUpDto>(
            ObjectMapper.Map<List<Author>, List<AuthorsLookUpDto>>(authors));
    }
}