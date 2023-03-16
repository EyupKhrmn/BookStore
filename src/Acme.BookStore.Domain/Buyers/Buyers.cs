using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Buyers;

public class Buyers : FullAuditedAggregateRoot<Guid>
{
    public string Name { get; set; }
    public float Balance { get; set; }
    
}