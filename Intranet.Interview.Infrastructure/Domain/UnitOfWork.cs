using Intranet.Interview.Infrastructure.Data;
using Mapper.GSB.Domain.SeedWork;

namespace Intranet.Interview.Infrastructure.Domain;

internal class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext context;    
    public UnitOfWork(AppDbContext context)
    {
        this.context = context;
    }
    public async Task CommitAsync(CancellationToken cancellationToken = default) => await context.SaveChangesAsync(cancellationToken);
}
