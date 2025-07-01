using Catalog.Core.Repositories;
using Caatalog.Application.Features.Products.Commands.Responses;
using Caatalog.Application.Mappers;
using Catalog.Core.Entities;
using MediatR;
using System;

namespace Caatalog.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ProductResponse>
    {
        private readonly IProductRepository _productRepository;
        public CreateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = ProductMapper.Mapper.Map<Product>(request);
            if (product == null)
            {
                throw new ApplicationException("Product not found");
            }
            var createdProduct = await _productRepository.CreateProductAsync(product);
            return ProductMapper.Mapper.Map<ProductResponse>(createdProduct);
        }
    }
}