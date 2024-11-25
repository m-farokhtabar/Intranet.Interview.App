using Intranet.Interview.Domain.DataForm;
using Intranet.Interview.Infrastructure.Data.Config;
using Intranet.Interview.Infrastructure.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Intranet.Interview.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> Options) : base(Options)
    {
    }
    public DbSet<FormData> FormData { get; set; }    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(FormDataConfig).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
