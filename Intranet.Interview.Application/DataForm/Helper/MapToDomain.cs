using Intranet.Interview.Domain.DataForm;

namespace Intranet.Interview.Application.DataForm.Helper;

internal static class MapToDomain
{
    public static IndustryType? MapToIndustryType(string? value)
    {
        if (Enum.TryParse(value, out IndustryType industry))
            return industry;
        else
            return null;
    }
}
