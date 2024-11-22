using Intranet.Interview.UI.Client.Model;
using System.Net.Http.Json;
using System.Text;
using static Intranet.Interview.UI.Client.Services.FormSrv.FormServiceHelper;


namespace Intranet.Interview.UI.Client.Services.FormSrv
{
    public class FormService : IFormService
    {
        private readonly HttpClient http;

        public FormService(HttpClient http)
        {
            this.http = http;
        }
        public async Task<FormMetadata> GetFormMeta(string formName)
        {
            var result = await http.GetFromJsonAsync<FormMetadata>($"api/{formName}/MetaData");
            return result is null ? throw new Exception() : result;
        }
        /// <summary>
        /// Save Data Form Based on form name
        /// </summary>
        /// <param name="Fields"></param>
        /// <param name="formName"></param>
        /// <returns></returns>
        public async Task<bool> PostFormData(List<Field> fields, string formName)
        {
            string jsonForm = FieldsToJson(fields);
            Console.WriteLine(jsonForm);
            StringContent content = new(jsonForm, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await http.PostAsync($"api/{formName}", content);

            return response.IsSuccessStatusCode;
        }
    }
}
