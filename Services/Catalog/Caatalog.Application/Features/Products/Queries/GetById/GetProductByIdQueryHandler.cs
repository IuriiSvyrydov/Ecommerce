using Caatalog.Application.Features.Products.Commands.Responses;
using Catalog.Core.Repositories;
using Caatalog.Application.Mappers;
using MediatR;

namespace Caatalog.Application.Features.Products.Queries.GetById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductResponse>
    {
        private readonly IProductRepository _productRepository;
        public GetProductByIdQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<ProductResponse> Handle(GetProductByIdQuery request,
         CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetProductAsync(request.Id);
            var productResponse = ProductMapper.Mapper.Map<ProductResponse>(product);
            return productResponse;
        }
    }
}