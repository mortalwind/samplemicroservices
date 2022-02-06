namespace ContactService.Core.Dto;

/// <summary>
/// Rehberdeki Kişinin detayları ile bilgisi
/// </summary>
public class ContactPersonDetailDto
{

    /// <summary>
    /// Kişinin benzersiz IDsi
    /// </summary>
    public Guid UUID { get; set; }
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

    /// <summary>
    /// İletişim bilgileri
    /// </summary>
    public List<ContactInfoDto> ContactDetails { get; set; }
}
