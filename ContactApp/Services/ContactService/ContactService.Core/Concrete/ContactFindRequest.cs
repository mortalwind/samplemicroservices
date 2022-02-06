using ContactService.Core.Abstract;

namespace ContactService.Core.Concrete;

/// <summary>
/// Rehberde kişilerin filtrelenmesi isteği
/// <para>Ad ve/veya soyad bilgileri ile sayfalamaya uygun istek oluşturur</para>
/// </summary>
public class ContactFindRequest : PagingRequest
{
    public string Name { get; set; }
    public string Lastname { get; set; }

}
