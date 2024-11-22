namespace Intranet.Interview.Domain.DataForm;

/// <summary>
/// Manage people data from an external resource.
/// </summary>
public interface IPersonRepository
{
    /// <summary>
    /// Insert new person
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    Task AddAsync(Person entity);
}
