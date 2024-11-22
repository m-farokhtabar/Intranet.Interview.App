namespace Intranet.Interview.Application.DataForm.Dto;

public class FieldDto
{
    public string Type { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
    public bool? Required { get; set; }
    public int? Min { get; set; }
    public int? Max { get; set; }
    public List<string>? Values { get; set; }
}
