using Catalog.Core.Repositories;
using Caatalog.Application.Features.Products.Commands.Responses;
using Caatalog.Application.Mappers;
using Catalog.Core.Entities;
using MediatR;

namespace Caatalog.Application.Features.Products.Queries.GetByName
{
    public class GetProductByNameQueryHandler : IRequestHandler<GetProductByNameQuery, ProductResponse>
    {
        private readonly IProductRepository _productRepository;
        public GetProductByNameQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<ProductResponse> Handle(GetProductByNameQuery request,
         CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetProductByNameAsync(request.Name);
            var productResponse = ProductMapper.Mapper.Map<ProductResponse>(product);
            return productResponse;
        }
    }
}