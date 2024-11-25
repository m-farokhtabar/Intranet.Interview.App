using Intranet.Interview.Application.SeedWorks;
using Intranet.Interview.Domain.DataForm;
using Intranet.Interview.Infrastructure.Data;
using Intranet.Interview.Infrastructure.Data.ReadDb;
using Intranet.Interview.Infrastructure.DbProvider;
using Intranet.Interview.Infrastructure.Domain;
using Mapper.GSB.Domain.SeedWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Intranet.Interview.Infrastructure.StartupConfig;

/// <summary>
/// all Settings for using Infrastructure layer
/// </summary>
public static class InfrastructureServiceExtension
{
    /// <summary>
    /// configure services and database
    /// </summary>
    /// <param name="services"></param>
    /// <param name="dbConnection"></param>
    public static void InfrastructureConfiguration(this IServiceCollection services, string dbConnection, string readDbConnection)
    {
        services.AddScoped<IFormMetaDataProvider, FormMetaDataProvider>();
        services.AddScoped<IFormDataRepository, FormDataRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddDbContext<AppDbContext>(Opts => Opts.UseInMemoryDatabase(dbConnection));
        services.AddSingleton<IReadDataDbConnection>(_ => new ReadDataDbConnection(readDbConnection));
    }
}
