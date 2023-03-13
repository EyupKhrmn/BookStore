using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.BookStore.Authors;

public class CreateUpdateAuthorDto
{
    [Required]
    [StringLength(61)]
    public string Name { get; set; }
    
    [Required] public DateTime BirthDate { get; set; }
    
    [Required]
    [StringLength(300)]
    public string ShortBio { get; set; }
}