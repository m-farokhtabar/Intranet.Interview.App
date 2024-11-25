using Intranet.Interview.UI.Client.Model;

namespace Intranet.Interview.UI.Client.Services.FormSrv
{
    public interface IFormService
    {
        Task<FormMetadata> GetFormMeta(Guid formId);
        Task<(bool serverStatus, string json)> PostFormData(List<Field> fields);
    }
}