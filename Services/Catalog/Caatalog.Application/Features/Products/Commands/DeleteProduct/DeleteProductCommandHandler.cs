
using Catalog.Core.Repositories;
using MediatR;

namespace Caatalog.Application.Features.Products.Commands.DeleteProduct
{
    public sealed class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, bool>
    {
        private readonly IProductRepository _productRepository;
        public DeleteProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetProductAsync(request.Id);
            if (product == null)
            {
                throw new ApplicationException("Product not found");
            }
            await _productRepository.DeleteProductAsync(request.Id);
            return true;
        }
    }
}