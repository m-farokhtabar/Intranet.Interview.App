using Intranet.Interview.UI.Client.Model;

namespace Intranet.Interview.UI.Client.Services.FormSrv
{
    public interface IFormService
    {
        Task<FormMetadata> GetFormMeta(string formName);
        Task<bool> PostFormData(List<Field> fields, string formName);
    }
}