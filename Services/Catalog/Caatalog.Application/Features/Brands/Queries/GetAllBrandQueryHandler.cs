using AutoMapper;
using Caatalog.Application.Mappers;
using Catalog.Application.Features.Brands.Responses;
using Catalog.Core.Entities;
using Catalog.Core.Repositories;
using MediatR;

namespace Caatalog.Application.Features.Brands.Queries
{
    public sealed class GetAllBrandQueryHandler : IRequestHandler<GetAllBrandsQuery, List<BrandResponse>>
    {
        private readonly IBrandRepository _brandRepository;
     
        public GetAllBrandQueryHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
            
        }


        public async Task<List<BrandResponse>> Handle(GetAllBrandsQuery request, CancellationToken cancellationToken)
        {
            var brands = await _brandRepository.GetBrandsAsync();
            var brandResponse = ProductMapper.Mapper.Map<List<ProductBrand>, List<BrandResponse>>(brands.ToList());
            return brandResponse;
        }
    }
}