
using Catalog.Core.Entities;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;

namespace Catalog.Infrastructure.Data.SeedData
{
    public  class CatalogContext : ICatalogContext
    {
        public IMongoCollection<ProductBrand> Brands { get; }
        public IMongoCollection<ProductType> Types { get; }
        public IMongoCollection<Product> Products { get; }
        public CatalogContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));
            Brands = database.GetCollection<ProductBrand>(configuration.GetValue<string>("DatabaseSettings:BrandsCollectionName"));
            Types = database.GetCollection<ProductType>(configuration.GetValue<string>("DatabaseSettings:TypesCollectionName"));
            Products = database.GetCollection<Product>(configuration.GetValue<string>("DatabaseSettings:CollectionName"));
            BrandContextSeed.SeedData(Brands);
            TypeContextSeed.SeedData(Types);
            ProductContextSeed.SeedData(Products);
            
      }
    }
}