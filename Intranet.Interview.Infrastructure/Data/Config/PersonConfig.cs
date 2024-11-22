using Intranet.Interview.Domain.DataForm;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Intranet.Interview.Infrastructure.Data.Config
{
    /// <summary>
    /// Configuration class for the Person entity, defining the mapping between the entity and the database table
    /// </summary>
    internal class PersonConfig : IEntityTypeConfiguration<Person>
    {
        /// <summary>
        /// Configures the table and columns for the Person entity.
        /// This method specifies key constraints, property requirements, 
        /// column configurations, and indexes.
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Person> builder)
        {            
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Version).IsRequired(true);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired();
            builder.Property(x => x.RowVersion).IsRowVersion();

            builder.Property(x => x.Name).IsRequired(true);
            builder.Property(x => x.Email).IsRequired(true);
            builder.Property(x => x.Age).IsRequired(false);
            builder.Property(x => x.Industry).IsRequired(true);
            builder.Property(x => x.SubscribeToNewsletter).IsRequired(false);                       
        }
    }
}
