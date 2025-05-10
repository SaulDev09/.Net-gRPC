using Microsoft.EntityFrameworkCore;
using Sc.Trade.Domain.Entities;

namespace Sc.Trade.Application.Interfaces.Persistence
{
    public interface IApplicationDbContext
    {
        DbSet<Order> Orders { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
