using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;

namespace Acme.BookStore.Books;

public class BookDto : AuditedEntityDto<Guid>, IEntity<Guid>
{
    public string Name { get; set; }
    public BookType Type { get; set; }
    public DateTime PublishDate { get; set; }
    public float Price { get; set; }
    public int Stock { get; set; }

    #region Relations

    public Guid AuthorId { get; set; }
    public string AuthorName { get; set; }

    #endregion

    public object[] GetKeys()
    {
        throw new NotImplementedException();
    }
}