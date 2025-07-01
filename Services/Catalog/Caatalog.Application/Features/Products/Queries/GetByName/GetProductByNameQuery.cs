using Caatalog.Application.Features.Products.Commands.Responses;
using MediatR;


namespace Caatalog.Application.Features.Products.Queries.GetByName;

public sealed class GetProductByNameQuery : IRequest<ProductResponse>
{
    public string Name { get; set; }
    public GetProductByNameQuery(string name)
    {
        Name = name;
    }
}