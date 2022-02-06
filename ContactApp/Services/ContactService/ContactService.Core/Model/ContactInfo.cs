using ContactService.Core.Concrete;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ContactService.Core.Model;

/// <summary>
/// Kişiye ilişkin iletişim bilgisi
/// </summary>
public class ContactInfo
{

    /// <summary>
    /// İletişim bilgisi benzersiz IDsi
    /// </summary>
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    
    /// <summary>
    /// Bilginin tipi
    /// <para>Telefon, Email, konum vb...</para>
    /// </summary>
    public ContactInfoType InfoType { get; set; }

    /// <summary>
    /// Bilginin içeriği
    /// </summary>
    public string Content { get; set; }
}
