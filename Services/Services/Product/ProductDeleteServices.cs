using Domain.Repositories;
using Serilog;

namespace Services.Services;

public class ProductDeleteServices : IProductDeleteServices
{
    private readonly IProductRepository _repository;
    private readonly ILogger _logger;


    public ProductDeleteServices(IProductRepository repository, ILogger logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public async Task<bool> ExecuteAsync(string id, CancellationToken cancellationToken = default)
    {
        try { 
        return await _repository.DeleteAsync(id);
        }
        catch (Exception ex)
        {
            _logger.Error(ex.Message); return false;
        }
    }
}