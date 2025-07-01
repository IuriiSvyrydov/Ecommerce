using AutoMapper;
using Caatalog.Application.Features.Products.Commands.CreateProduct;
using Caatalog.Application.Features.Products.Commands.Responses;
using Caatalog.Application.Features.Products.Commands.UpdateProduct;
using Caatalog.Application.Features.Types.Responses;
using Catalog.Application.Features.Brands.Responses;
using Catalog.Core.Entities;

namespace Caatalog.Application.Mappers
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Product, ProductResponse>().ReverseMap();
            CreateMap<ProductBrand, BrandResponse>().ReverseMap();
            CreateMap<ProductType, TypeResponse>().ReverseMap();
            CreateMap<Product, CreateProductCommand>().ReverseMap();
            CreateMap<Product, UpdateProductCommand>().ReverseMap();
        }
    }
}