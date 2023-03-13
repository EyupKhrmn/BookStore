using System;
using System.Linq;
using System.Threading.Tasks;
using Acme.BookStore.Authors;
using Shouldly;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Validation;
using Xunit;

namespace Acme.BookStore.Books;

public class BookAppService_Tests
{
    private readonly IBookAppService _bookAppService;
    private readonly IAuthorAppService _authorAppService;

    public BookAppService_Tests(IBookAppService bookAppService, IAuthorAppService authorAppService)
    {
        _bookAppService = bookAppService;
        _authorAppService = authorAppService;
    }

    #region Old Codes

    // [Fact]
    // public async Task Should_Get_List_Of_Books()
    // {
    //     var result = await _bookAppService.GetListAsync(
    //         new PagedAndSortedResultRequestDto()
    //         
    //         );
    //     
    //     result.TotalCount.ShouldBeGreaterThan(0);
    //     result.Items.ShouldContain(b => b.Name == "1984");
    //     
    //     
    // }
    //
    // [Fact]
    // public async Task Should_Create_A_Valid_Book()
    // {
    //     var result = await _bookAppService.CreateAsync(
    //         new CreateUpdateBookDto
    //         {
    //             Name = "New Test Book 61",
    //             Price = 61,
    //             PublishDate = DateTime.Now,
    //             Type = BookType.Science
    //         });
    //     
    //     result.Id.ShouldNotBe(Guid.Empty);
    //     result.Name.ShouldBe("New Test Book 61");
    //
    // }
    //
    // [Fact]
    // public async Task Should_Not_Create_A_Book_Without_Name()
    // {
    //     var exception = await Assert.ThrowsAsync<AbpValidationException>(async () =>
    //     {
    //         await _bookAppService.CreateAsync(new CreateUpdateBookDto
    //         {
    //             Name = "",
    //             Price = 61,
    //             PublishDate = DateTime.Now,
    //             Type = BookType.ScienceFiction
    //         });
    //     });
    //     
    //     exception.ValidationErrors.ShouldContain(err => err.MemberNames.Any(mem => mem == "Name"));
    // }

    #endregion
    
    
    [Fact]
    public async Task Should_Get_List_Of_Books()
    {
        //Act
        var result = await _bookAppService.GetListAsync(
            new PagedAndSortedResultRequestDto()
        );

        //Assert
        result.TotalCount.ShouldBeGreaterThan(0);
        result.Items.ShouldContain(b => b.Name == "1984" &&
                                        b.AuthorName == "George Orwell");
    }

    [Fact]
    public async Task Should_Create_A_Valid_Book()
    {
        var authors = await _authorAppService.GetListAsync(new GetAuthorListDto());
        var firstAuthor = authors.Items.First();

        //Act
        var result = await _bookAppService.CreateAsync(
            new CreateUpdateBookDto
            {
                AuthorId = firstAuthor.Id,
                Name = "New test book 42",
                Price = 10,
                PublishDate = System.DateTime.Now,
                Type = BookType.ScienceFiction
            }
        );

        //Assert
        result.Id.ShouldNotBe(Guid.Empty);
        result.Name.ShouldBe("New test book 42");
        /*merhaba beler */
    }

    [Fact]
    public async Task Should_Not_Create_A_Book_Without_Name()
    {
        var exception = await Assert.ThrowsAsync<AbpValidationException>(async () =>
        {
            await _bookAppService.CreateAsync(
                new CreateUpdateBookDto
                {
                    Name = "",
                    Price = 10,
                    PublishDate = DateTime.Now,
                    Type = BookType.ScienceFiction
                }
            );
        });

        exception.ValidationErrors
            .ShouldContain(err => err.MemberNames.Any(m => m == "Name"));
    }
}