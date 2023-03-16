using System;
using System.Threading.Tasks;

namespace Acme.BookStore.Buyers;

public interface IBuyersService
{
    public Task<BuyerDto> GetAsync(Guid id);

    public void Buy(Guid BookId);
}