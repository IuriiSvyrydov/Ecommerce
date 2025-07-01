using MediatR;
using Catalog.Core.Repositories;
using Caatalog.Application.Features.Products.Commands.Responses;
using Caatalog.Application.Mappers;
using Catalog.Core.Entities;

namespace Caatalog.Application.Features.Products.Queries;

public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<ProductResponse>>
{
    private readonly IProductRepository _productRepository;
    public GetAllProductsQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public async Task<List<ProductResponse>> Handle(GetAllProductsQuery request,
     CancellationToken cancellationToken)
    {
        var products = await _productRepository.GetProductsAsync();
        var productResponse = ProductMapper.Mapper.Map<List<Product>, List<ProductResponse>>(products.ToList());
        return productResponse;
    }
}