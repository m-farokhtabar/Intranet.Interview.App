using Intranet.Interview.Domain.DataForm;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Intranet.Interview.Infrastructure.Data.Config
{
    /// <summary>
    /// Configuration class for the FormData entity, defining the mapping between the entity and the database table
    /// </summary>
    internal class FormDataConfig : IEntityTypeConfiguration<FormData>
    {
        /// <summary>
        /// Configures the table and columns for the FormData entity.
        /// This method specifies key constraints, property requirements, 
        /// column configurations, and indexes.
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<FormData> builder)
        {            
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Version).IsRequired(true);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired();
            builder.Property(x => x.RowVersion).IsRowVersion();

            builder.Property(x => x.JsonData).IsRequired(true);            
        }
    }
}
