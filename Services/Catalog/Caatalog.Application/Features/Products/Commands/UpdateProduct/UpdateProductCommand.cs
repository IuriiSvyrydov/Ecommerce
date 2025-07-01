
using Caatalog.Application.Features.Products.Commands.Responses;
using Catalog.Core.Entities;
using MediatR;

namespace Caatalog.Application.Features.Products.Commands.UpdateProduct
{
    public sealed class UpdateProductCommand : IRequest<bool>
    {
        public string Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public string ImageFile { get; set; } = string.Empty;
        public ProductBrand Brands { get; set; }
        public ProductType Types { get; set; }
        
    }
}