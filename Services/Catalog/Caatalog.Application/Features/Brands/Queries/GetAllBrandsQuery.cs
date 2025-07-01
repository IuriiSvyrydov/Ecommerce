using Catalog.Application.Features.Brands.Responses;
using MediatR;

namespace Caatalog.Application.Features.Brands.Queries
{
    public class GetAllBrandsQuery : IRequest<List<BrandResponse>>
    {
        
    }
}