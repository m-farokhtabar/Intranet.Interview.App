using Intranet.Interview.Domain.DataForm;
using Intranet.Interview.Infrastructure.Data.Config;
using Microsoft.EntityFrameworkCore;

namespace Intranet.Interview.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> Options) : base(Options)
    {
    }
    public DbSet<Person> Persons { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PersonConfig).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
