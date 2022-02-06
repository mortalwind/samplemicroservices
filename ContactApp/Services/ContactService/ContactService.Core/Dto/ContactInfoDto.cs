using ContactService.Core.Concrete;
using System.Text.Json.Serialization;

namespace ContactService.Core.Dto;

/// <summary>
/// Rehber Kişinin iletişim bilgisi 
/// </summary>
public class ContactInfoDto
{
    public Guid uuid { get; set; }

    [JsonIgnore]
    private ContactInfoType _ContactInfoType { get; set; }

    /// <summary>
    /// Bilginin tipi
    /// </summary>
    public string InfoType
    {
        get
        {
            string typeName = "";
            switch (_ContactInfoType)
            {
                case ContactInfoType.PhoneNumber:
                    typeName = "Telefon Numarası";
                    break;
                case ContactInfoType.Email:
                    typeName = "E-mail Adresi";
                    break;
                case ContactInfoType.Location:
                    typeName = "Konum";
                    break;
                default:
                    break;
            }
            return typeName;
        }
    }

    /// <summary>
    /// Bilginin içeriği
    /// </summary>
    public string Content { get; set; }
}
