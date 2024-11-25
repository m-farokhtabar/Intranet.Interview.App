using Mapper.GSB.Domain.SeedWorks;

namespace Intranet.Interview.Domain.DataForm
{
    public class FormData : AggregateRoot
    {
        /// <summary>
        /// just for EF
        /// </summary>
        private FormData()
        {
            
        }
        public FormData(string? jsonData) : base(DateTime.Now, Guid.NewGuid(), 1)
        {
            if (string.IsNullOrWhiteSpace(jsonData))
                throw new Exception();
            JsonData = jsonData;
        }
        public string JsonData { get; private set; }
    }
}
