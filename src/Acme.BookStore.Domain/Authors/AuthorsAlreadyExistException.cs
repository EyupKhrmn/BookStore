using Volo.Abp;

namespace Acme.BookStore.Authors;

public class AuthorsAlreadyExistException : BusinessException
{
    public AuthorsAlreadyExistException(string name) : base(BookStoreDomainErrorCodes.AuthorAlreadyExists)
    {
        WithData("name", name);
    }
}