using Caatalog.Application.Features.Products.Commands.Responses;
using MediatR;

namespace Caatalog.Application.Features.Products.Queries
{
    public class GetAllProductsQuery : IRequest<List<ProductResponse>>
    {
        
    }
}