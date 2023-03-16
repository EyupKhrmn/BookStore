using System;
using System.Threading.Tasks;
using Acme.BookStore.Books;

namespace Acme.BookStore.Buyers;

public class BuyerAppService : BookStoreAppService,IBuyersService
{
    
    private readonly IBuyerRepository _buyerRepository;
    private readonly IBookAppService _bookAppService;

    public BuyerAppService(IBuyerRepository buyerRepository, IBookAppService bookAppService)
    {
        _buyerRepository = buyerRepository;
        _bookAppService = bookAppService;
    }

    public async Task<BuyerDto> GetAsync(Guid id)
    {
        var buyer = await _buyerRepository.GetAsync(id);
        return ObjectMapper.Map<Buyers, BuyerDto>(buyer);
        
    }

    public async void Buy(Guid BookId)
    {
        var book = await _bookAppService.GetBookDtoAsync(BookId);
        var stock = book.Stock - 1;

    }
}