using Intranet.Interview.Share.Validators;
using Mapper.GSB.Domain.SeedWorks;

namespace Intranet.Interview.Domain.DataForm
{
    public class Person : AggregateRoot
    {
        /// <summary>
        /// just for EF
        /// </summary>
        private Person()
        {
            
        }
        public Person(string? name, string? email, int? age, IndustryType? industry, bool? subscribeToNewsletter) : base(DateTime.Now, Guid.NewGuid(), 1)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception();
            if (string.IsNullOrWhiteSpace(email) || !email.IsValidEmail())
                throw new Exception();
            if (age.HasValue && (age < 18 || age > 100))
                throw new Exception();
            if (!industry.HasValue)
                throw new Exception();
            Name = name;
            Email = email;
            Age = age;
            Industry = industry.Value;
            SubscribeToNewsletter = subscribeToNewsletter;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public int? Age { get; private set; }
        public IndustryType Industry { get; private set; }
        public bool? SubscribeToNewsletter { get; private set; }
    }
}
