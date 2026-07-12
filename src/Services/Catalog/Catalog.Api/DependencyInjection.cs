using Catalog.Application.Queries.BrandQueries;

namespace Catalog.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddApiServices(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(config =>
        {
            config.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Catalog API",
                Version = "v1"
            });
        });

        services.AddApiVersioning(options =>
        {
            options.ReportApiVersions = true;
            options.AssumeDefaultVersionWhenUnspecified = true;
            options.DefaultApiVersion = new ApiVersion(1, 0);
        }).AddApiExplorer(options =>
        {
            options.GroupNameFormat = "'v'VVV";
            options.SubstituteApiVersionInUrl = true;
        });

        var assembly = typeof(GetBrandsQuery).Assembly;

        var licenseKey = configuration.GetSection("MediatR:LicenseKey").Value;

        services.AddMediatR(config =>
        {
            config.LicenseKey = licenseKey;
            config.RegisterServicesFromAssemblies(assembly);
        });

        return services;
    }

    public static WebApplication UseApiServices(this WebApplication app)
    {
        app.MapControllers();
        if (true || app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.MapGet("/", () => "Hello World!!!");
        return app;
    }
}
