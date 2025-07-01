
using MongoDB.Bson.Serialization.Attributes;

namespace Catalog.Core.Entities;

public sealed class ProductType : BaseEntity
{
    [BsonElement("Name")]
    public string Name { get; set; }
    
}
