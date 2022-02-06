namespace ContactService.Core.Dto;

/// <summary>
/// Rehber Kişisi
/// </summary>
public class ContactPersonDto
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
}
