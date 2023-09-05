using Domain.Repositories;
using Infra.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace Infra;

public static class RepositoryInjections
{
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddSingleton<IMongoClient>(sp =>
        {
            var config = sp.GetRequiredService<IConfiguration>();
            var connectionString = config.GetConnectionString("MongoDB");
            return new MongoClient(connectionString);
        });

        services.AddTransient<IProductRepository, ProductRepository>(sp =>
        {
            var config = sp.GetRequiredService<IConfiguration>();
            var dbName = config["DatabaseSettings:DatabaseName"];
            var collectionName = config["DatabaseSettings:CollectionName"];
            var mongoClient = sp.GetRequiredService<IMongoClient>();

            if (dbName == null && collectionName == null) throw new Exception("dbName and collection is null");

            return new ProductRepository(mongoClient, dbName!, collectionName!);
        });
    }
}
