

using MongoDB.Bson.Serialization.Attributes;

namespace Catalog.Core.Entities;

public sealed class ProductBrand: BaseEntity
{
    [BsonElement("Name")]
    public string Name { get; set; } = string.Empty;
}
