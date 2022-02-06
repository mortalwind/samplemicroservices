using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ContactService.Core.Model;

/// <summary>
/// Kişi modeli
/// </summary>
public class ContactPerson
{
    /// <summary>
    /// Kişinin benzersiz IDsi
    /// </summary>
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    /// <summary>
    /// Adı
    /// </summary>
    public string FirstName { get; set; }
    /// <summary>
    /// Soyadı
    /// </summary>
    public string LastName { get; set; }
    /// <summary>
    /// Firması
    /// </summary>
    public string Company { get; set; }

    public IList<ContactInfo> ContactInfos { get; set; }
}
