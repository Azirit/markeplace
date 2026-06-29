using Catalog.Infrastructure.Data.Seed;
using Catalog.Infrastructure.Repositories;
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

        services.AddScoped<IBrandRepository, CatalogRepository>();
        services.AddScoped<ICategoryRepository, CatalogRepository>();
        services.AddScoped<ICatalogItemRepository, CatalogRepository>();

        return services;
    }
}
