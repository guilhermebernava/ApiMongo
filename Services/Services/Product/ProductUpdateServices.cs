using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using Serilog;
using Services.Dtos;

namespace Services.Services;
public class ProductUpdateServices : IProductUpdateServices
{
    private readonly IProductRepository _repository;
    private readonly IMapper _mapper;
    private readonly ILogger _logger;


    public ProductUpdateServices(IProductRepository repository, IMapper mapper, ILogger logger)
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<bool> ExecuteAsync(ProductUpdateDto dto, CancellationToken cancellationToken = default)
    {
        try
        {
            var entity = _mapper.Map<Product>(dto);
            return await _repository.UpdateAsync(entity);
        }
        catch (Exception ex)
        {
            _logger.Error(ex.Message);
            throw;
        }
        
    }
}