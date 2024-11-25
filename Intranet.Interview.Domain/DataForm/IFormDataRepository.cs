namespace Intranet.Interview.Domain.DataForm;

/// <summary>
/// Manage people data from an external resource.
/// </summary>
public interface IFormDataRepository
{
    /// <summary>
    /// Insert new Form
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    Task AddAsync(FormData entity);
}
