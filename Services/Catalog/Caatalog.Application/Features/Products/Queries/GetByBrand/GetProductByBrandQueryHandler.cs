using Catalog.Core.Repositories;
using Caatalog.Application.Features.Products.Commands.Responses;
using Caatalog.Application.Mappers;
using MediatR;

namespace Caatalog.Application.Features.Products.Queries.GetByBrand
{
    public sealed class GetProductByBrandQueryHandler : IRequestHandler<GetProductByBrandQuery, List<ProductResponse>>
    {
        private readonly IProductRepository _productRepository;
        public GetProductByBrandQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<ProductResponse>> Handle(GetProductByBrandQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetProductByBrandAsync(request.Brand);
            var productResponse = ProductMapper.Mapper.Map<List<ProductResponse>>(product);
            return productResponse;
        }
    }
}