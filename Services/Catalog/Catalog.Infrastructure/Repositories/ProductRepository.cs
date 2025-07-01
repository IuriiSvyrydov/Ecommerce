using Catalog.Core.Entities;
using Catalog.Core.Repositories;
using Catalog.Infrastructure.Data;
using MongoDB.Driver;

namespace Catalog.Infrastructure.Repositories
{
    public sealed class ProductRepository : IProductRepository,IBrandRepository,ITypeRepository
    {
        private readonly ICatalogContext _catalogContext;
        public ProductRepository(ICatalogContext catalogContext)
        {
            _catalogContext = catalogContext;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _catalogContext.Products.Find(p => true).ToListAsync();
        }

        public async Task<Product> GetProductAsync(string id)
        {
            return await _catalogContext.Products.Find(p => p.Id == id)
            .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Product>> GetProductByNameAsync(string brandName)
        {
            return await _catalogContext.Products.Find(p => p.Name.ToLower() == brandName.ToLower())
            .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductByBrandAsync(string brand)
        {
            return await _catalogContext.Products.Find(p => p.Brands.Name == brand)
            .ToListAsync();
        }

        public async Task<Product> CreateProductAsync(Product product)
        {
         
             await _catalogContext.Products.InsertOneAsync(product);
            return product;
        }

        public async Task<bool> UpdateProductAsync(Product product)
        {
         var updateProduct = await _catalogContext
            .Products.ReplaceOneAsync(p => p.Id == product.Id, product);
            return updateProduct.IsAcknowledged && updateProduct.ModifiedCount > 0;
        }

        public async Task<bool> DeleteProductAsync(string id)
        {
           var deleteProduct = await _catalogContext
           .Products.DeleteOneAsync(p => p.Id == id);
           return deleteProduct.IsAcknowledged && deleteProduct.DeletedCount > 0;
        }

        public async Task<IEnumerable<ProductBrand>> GetBrandsAsync()
        {
            return await _catalogContext.Brands.Find(p => true).ToListAsync();
        }

        public async Task<IEnumerable<ProductType>> GetTypesAsync()
        {
            return await _catalogContext.Types.Find(p => true).ToListAsync();
        }
    }
}