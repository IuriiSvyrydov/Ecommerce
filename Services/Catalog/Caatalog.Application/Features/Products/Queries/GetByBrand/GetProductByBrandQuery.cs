
using Caatalog.Application.Features.Products.Commands.Responses;
using MediatR;

namespace Caatalog.Application.Features.Products.Queries.GetByBrand
{
    public sealed class GetProductByBrandQuery : IRequest<List<ProductResponse>>
    {
        public string Brand { get; set; }
        public GetProductByBrandQuery(string brand)
        {
            Brand = brand;
        }
        
    }
}