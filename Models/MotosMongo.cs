
using MongoDB.Bson.Serialization.Attributes;

public class MotosMongo {
[BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string? Id { get; set; }

    public string marca { get; set; } = string.Empty;
    public string modelo { get; set; } = string.Empty;
    public int  tipo { get; set; } 
    public decimal cilindrada { get; set; }
    public decimal potencia_hp { get; set; }
    public string peso_kg { get; set; } =string.Empty;
    public int combustible  { get; set; }
    public int precio_usd { get; set; }
}