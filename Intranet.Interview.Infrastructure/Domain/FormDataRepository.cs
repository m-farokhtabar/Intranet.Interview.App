using Intranet.Interview.Domain.DataForm;
using Intranet.Interview.Infrastructure.Data;

namespace Intranet.Interview.Infrastructure.Domain;

/// <summary>
/// For Description <see cref="IFormDataRepository"/>
/// </summary>
internal class FormDataRepository : IFormDataRepository
{
    private readonly AppDbContext context;

    public FormDataRepository(AppDbContext context)
    {
        this.context = context;
    }
    /// <summary>
    /// For Description <see cref="IFormDataRepository.AddAsync(FormData)"/>
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    public async Task AddAsync(FormData entity) => await context.FormData.AddAsync(entity).ConfigureAwait(false);
}
