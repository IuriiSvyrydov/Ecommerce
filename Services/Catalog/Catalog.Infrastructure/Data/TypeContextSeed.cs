using Catalog.Core.Entities;
using MongoDB.Driver;
using Newtonsoft.Json;


namespace Catalog.Infrastructure.Data;

public static class TypeContextSeed
{
    public static void SeedData(IMongoCollection<ProductType> typeCollection)
    {
        bool checkTypes = typeCollection.Find(p => true).Any();
        string path = Path.Combine("Data", "SeedData", "types.json");
        if (!checkTypes)
        {
            var typesData = File.ReadAllText(path);
            var types = JsonConvert.DeserializeObject<List<ProductType>>(typesData);
            if(types != null )
            {
                foreach(var type in types)
                {
                    typeCollection.InsertOneAsync(type);
                }
            }
        }
        
    }
    
}