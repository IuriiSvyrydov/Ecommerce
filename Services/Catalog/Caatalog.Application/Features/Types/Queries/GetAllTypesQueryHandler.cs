using Catalog.Core.Repositories;
using Caatalog.Application.Features.Types.Responses;
using Caatalog.Application.Mappers;
using Catalog.Core.Entities;
using MediatR;

namespace Caatalog.Application.Features.Types.Queries
{
    public class GetAllTypesQueryHandler: IRequestHandler<GetAllTypesQuery, List<TypeResponse>>
    {
        private readonly ITypeRepository _typeRepository;
        public GetAllTypesQueryHandler(ITypeRepository typeRepository)
        {
            _typeRepository = typeRepository;
        }
        public async Task<List<TypeResponse>> Handle(GetAllTypesQuery request,
         CancellationToken cancellationToken)
        {
            var types = await _typeRepository.GetTypesAsync();
            var typeResponse = ProductMapper.Mapper.Map <List<TypeResponse>>(types.ToList());
            return typeResponse;
        }
    }
}