using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Services.Services;

namespace Services;

public static class ServicesInjections
{
    public static void AddServices(this IServiceCollection services)
    {
        Log.Logger = new LoggerConfiguration().CreateLogger();

        services.AddLogging(loggingBuilder =>
        {
            loggingBuilder.AddSerilog();
        });

        services.AddSingleton(Log.Logger);
        services.AddScoped<IProductCreateServices, ProductCreateServices>();
        services.AddScoped<IProductUpdateServices, ProductUpdateServices>();
        services.AddScoped<IProductDeleteServices, ProductDeleteServices>();
        services.AddScoped<IProductGetAllServices, ProductGetAllServices>();
        services.AddScoped<IProductGetByIdServices, ProductGetByIdServices>();
    }
}
