using Intranet.Interview.UI.Client.Model;
using System.Text.Json;

namespace Intranet.Interview.UI.Client.Services.FormSrv
{
    public static class FormServiceHelper
    {
        public static string FieldsToJson(List<Field> fields)
        {
            if (fields?.Count > 0)
            {
                var formData = new Dictionary<string, object?>();
                foreach (var field in fields)
                {
                    formData[field.Label] = field.Type switch
                    {
                        "text" or "email" or "dropdown" => field.StringValue,
                        "number" => field.IntValue,
                        "checkbox" => field.BoolValue,
                        _ => null
                    };
                }
                return JsonSerializer.Serialize(formData);
            }
            else
                return string.Empty;
        }
    }
}
