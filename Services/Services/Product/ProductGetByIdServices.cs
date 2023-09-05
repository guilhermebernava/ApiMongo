using Domain.Entities;
using Domain.Repositories;
using Serilog;

namespace Services.Services;
public class ProductGetByIdServices : IProductGetByIdServices
{
    private readonly IProductRepository _repository;
    private readonly ILogger _logger;


    public ProductGetByIdServices(IProductRepository repository, ILogger logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public async Task<Product> ExecuteAsync(string id, CancellationToken cancellationToken = default)
    {
        try
        {
            return await _repository.GetByIdAsync(id);

        }
        catch (Exception ex)
        {
            _logger.Error(ex.Message);
            throw;
        }
    }
}