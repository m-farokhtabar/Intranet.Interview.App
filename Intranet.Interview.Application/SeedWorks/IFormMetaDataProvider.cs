using Intranet.Interview.Application.DataForm.Dto;

namespace Intranet.Interview.Application.SeedWorks;

/// <summary>
/// Retrieve and manage form metadata from an external resource.
/// </summary>
public interface IFormMetaDataProvider
{
    /// <summary>
    /// Retrieve form metadata by identifier
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<FormMetadataDto> Get(Guid id);
}
