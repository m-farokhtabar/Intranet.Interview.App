namespace Intranet.Interview.Application.DataForm.Dto;

public class FormMetadataDto
{
    public string Title { get; set; } = string.Empty;
    public List<FieldDto> Fields { get; set; } = [];
}
