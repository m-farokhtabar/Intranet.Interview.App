using Intranet.Interview.Domain.DataForm;
using Intranet.Interview.Infrastructure.Data;

namespace Intranet.Interview.Infrastructure.Domain;

/// <summary>
/// For Description <see cref="IPersonRepository"/>
/// </summary>
internal class PersonRepository : IPersonRepository
{
    private readonly AppDbContext context;

    public PersonRepository(AppDbContext context)
    {
        this.context = context;
    }
    /// <summary>
    /// For Description <see cref="IPersonRepository.AddAsync(Person)"/>
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    public async Task AddAsync(Person entity) => await context.Persons.AddAsync(entity).ConfigureAwait(false);
}
