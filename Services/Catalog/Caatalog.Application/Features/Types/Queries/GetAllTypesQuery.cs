using Caatalog.Application.Features.Types.Responses;
using MediatR;

namespace Caatalog.Application.Features.Types.Queries
{
    public class GetAllTypesQuery : IRequest<List<TypeResponse>>
    {
        
    }
}