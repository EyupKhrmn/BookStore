using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Acme.BookStore.Books;

public class CreateUpdateBookDto
{
    [Required]
    [StringLength(128)]
    public String Name { get; set; }

    [Required]
    public BookType Type { get; set; } = BookType.Undefined;
    
    [Required]
    [DataType(DataType.Date)]
    public DateTime PublishDate { get; set; } = DateTime.Now;
    
    [Required] 
    public float Price { get; set; }

    #region Relations

    public Guid AuthorId { get; set; }

    #endregion
}