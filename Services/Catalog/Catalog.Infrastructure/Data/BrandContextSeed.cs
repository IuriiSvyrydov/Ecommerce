
using Catalog.Core.Entities;
using MongoDB.Driver;
using Newtonsoft.Json;

namespace Catalog.Infrastructure.Data
{
    public static class BrandContextSeed
    {
        public static void SeedData(IMongoCollection<ProductBrand> brandCollection)
        {
            bool checkBrands = brandCollection.Find(p => true).Any();
            string path = Path.Combine("Data", "SeedData", "brands.json");
            if (!checkBrands)
            {
                var brandsData = File.ReadAllText(path);
                var brands = JsonConvert.DeserializeObject<List<ProductBrand>>(brandsData);
                if(brands != null )
                {
                    foreach(var brand in brands)
                    {
                        brandCollection.InsertOneAsync(brand);
                    }
                }
            }
            
        }
    }
}