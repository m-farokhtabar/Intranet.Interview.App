using Intranet.Interview.Application.DataForm.Dto;
using Intranet.Interview.Application.SeedWorks;

namespace Intranet.Interview.Infrastructure.DbProvider;

internal class FormMetaDataProvider : IFormMetaDataProvider
{
    public async Task<FormMetadataDto> Get(Guid id)
    {
        var sampleForm = new FormMetadataDto
        {
            Title = "Person Form",
            Fields =
            [
                new FieldDto { Type = "text", Label = "Name", Required = true },
                new FieldDto { Type = "email", Label = "Email", Required = true },
                new FieldDto { Type = "number", Label = "Age", Min = 18, Max = 100 },
                new FieldDto { Type = "dropdown", Label = "Industry", Values = ["Tech", "Production", "Health"], Required = true },
                new FieldDto { Type = "checkbox", Label = "Subscribe to Newsletter", Required = false }
            ]
        };

        return await Task.FromResult(sampleForm).ConfigureAwait(false);
    }
}
