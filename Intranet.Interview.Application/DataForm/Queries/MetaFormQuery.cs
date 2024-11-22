using Intranet.Interview.Application.DataForm.Dto;
using MediatR;

namespace Intranet.Interview.Application.DataForm.Queries;

/// <summary>
/// Retrieve all metadata information related to the form ID to dynamically generate the form.
/// </summary>
/// <param name="Id"></param>
public record MetaFormQuery(Guid Id) : IRequest<FormMetadataDto>;
