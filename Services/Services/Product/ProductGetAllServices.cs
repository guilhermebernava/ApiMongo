using Domain.Entities;
using Domain.Repositories;
using Serilog;

namespace Services.Services;
public class ProductGetAllServices : IProductGetAllServices
{
    private readonly IProductRepository _repository;
    private readonly ILogger _logger;


    public ProductGetAllServices(IProductRepository repository, ILogger logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public async Task<List<Product>> ExecuteAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            return await _repository.GetAllAsync();
        }
        catch (Exception ex)
        {
            _logger.Error(ex.Message);
            throw;
        }
    }
}