using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Linq;
using MongoDB.Bson;


namespace Catalog.Core.Entities;

public sealed class Product : BaseEntity
{
    [BsonElement("Name")]
    public string Name { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public string ImageFile { get; set; } = string.Empty;
    public ProductBrand Brands { get; set; }
    public ProductType Types { get; set; }
    [BsonRepresentation(BsonType.Decimal128)]
    public decimal Price { get; set; }

}
