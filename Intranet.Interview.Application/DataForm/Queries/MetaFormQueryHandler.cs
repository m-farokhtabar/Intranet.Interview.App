using Intranet.Interview.Application.DataForm.Dto;
using Intranet.Interview.Application.SeedWorks;
using MediatR;

namespace Intranet.Interview.Application.DataForm.Queries;

internal class MetaFormQueryHandler : IRequestHandler<MetaFormQuery, FormMetadataDto>
{
    private readonly IFormMetaDataProvider provider;

    public MetaFormQueryHandler(IFormMetaDataProvider provider)
    {
        this.provider = provider;
    }
    public async Task<FormMetadataDto> Handle(MetaFormQuery request, CancellationToken cancellationToken)
    {
        if (request is null)
            throw new Exception();
        
        var result = await provider.Get(request.Id).ConfigureAwait(false);
        
        return result is null ? throw new Exception() : result;
    }
}
