using Domain.Entities;
using Domain.Repositories;
using MongoDB.Driver;

namespace Infra.Repositories;


public class ProductRepository : IProductRepository
{
    private readonly IMongoCollection<Product> _collection;

    public ProductRepository(IMongoClient client, string dbName, string collectionName)
    {
        var database = client.GetDatabase(dbName);
        _collection = database.GetCollection<Product>(collectionName);
    }

    public async Task<List<Product>> GetAllAsync()
    {
        var products = await _collection.Find(_ => true).ToListAsync();
        return products;
    }

    public async Task<Product> GetByIdAsync(string id)
    {
        var product = await _collection.Find(p => p.Id == id).FirstOrDefaultAsync();
        return product;
    }

    public async Task<bool> CreateAsync(Product product)
    {
        try
        {
            await _collection.InsertOneAsync(product);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> UpdateAsync(Product product)
    {
        try
        {
            await _collection.ReplaceOneAsync(p => p.Id == product.Id, product);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> DeleteAsync(string id)
    {
        try
        {
            await _collection.DeleteOneAsync(p => p.Id == id);
            return true;
        }
        catch
        {
            return false;
        }
    }
}

