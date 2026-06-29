using Catalog.Infrastructure.Data.Seed;
using Marten;

namespace Catalog.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        services.AddMarten(options =>
        {
            options.Connection(configuration.GetConnectionString("PostgreSQL")!);
        })
        .UseLightweightSessions()
        .InitializeWith(new[] { new InitializeDatabaseAsync() });

        return services;
    }
}
