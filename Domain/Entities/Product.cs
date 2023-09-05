using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Entities;

public class Product
{
    public Product()
    {

    }
    public Product(string name, string price)
    {
        Id = ObjectId.GenerateNewId().ToString();;
        Name = name;
        Price = price;
    }

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Name { get; set; }
    public string Price { get; set; }
}
