using ContactService.Core.Abstract;
using ContactService.Core.Model;

namespace ContactService.Core.Concrete;

/// <summary>
/// Arama sonucunda sayfalamaya uygun sonuçları içerir
/// </summary>
public class ContactFindResultWithPaging : PagingResult<ContactInfo>
{
}
