using Caatalog.Application.Features.Products.Commands.Responses;
using MediatR;

namespace Caatalog.Application.Features.Products.Queries.GetById
{
    public class GetProductByIdQuery : IRequest<ProductResponse>
    {
        public string Id { get; set; }
        public GetProductByIdQuery(string id)
        {
            Id = id;
        }
    }
}