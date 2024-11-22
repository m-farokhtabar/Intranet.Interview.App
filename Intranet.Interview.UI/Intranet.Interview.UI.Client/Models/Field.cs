namespace Intranet.Interview.UI.Client.Model;

public class Field
{
    public string Type { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
    public bool? Required { get; set; }
    public int? Min { get; set; }
    public int? Max { get; set; }
    public List<string>? Values { get; set; }
    /// <summary>
    /// it means the current value of field
    /// </summary>
    public string? StringValue { get; set; }
    public int? IntValue { get; set; }
    public bool BoolValue { get; set; }
}
