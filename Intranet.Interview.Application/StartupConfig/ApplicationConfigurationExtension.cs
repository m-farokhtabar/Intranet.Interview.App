using Intranet.Interview.Application.DataForm.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Intranet.Interview.Application.StratupConfig;

/// <summary>
///  all Settings for using Application layer
/// </summary>
public static class ApplicationConfigurationExtension
{
    /// <summary>
    /// configure MediatR
    /// </summary>
    /// <param name="services"></param>
    public static void ApplicationConfiguration(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<MetaFormQuery>());
    }
}
