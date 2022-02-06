using ContactService.Core.Concrete;
using ContactService.Core.Dto;
namespace ContactService.Core.Abstract;

public interface IContactRepository : IRepository<ContactPersonDto>
{
    /// <summary>
    /// Rehber kişilerinde arama yapar
    /// </summary>
    /// <param name="model">Arama kriterlerini içeren model</param>
    /// <returns></returns>
    Task<IEnumerable<ContactPersonDto>> FindAsync(ContactFindRequest model);

    /// <summary>
    /// Rehber kişisinin iletişim bilgisi ekler
    /// </summary>
    /// <param name="uuid">Kişinin bezersiz IDsi</param>
    /// <param name="model">İletişim bilgisi modeli</param>
    /// <returns></returns>
    Task<ContactInfoDto> CreateDetailAsync(Guid uuid, ContactInfoDto model);

    /// <summary>
    /// Rehber kişisinin iletişim bilgisi günceller
    /// </summary>
    /// <param name="model">İletişim bilgisi modeli</param>
    /// <returns></returns>
    Task<ContactInfoDto> UpdateDetailAsync(Guid uuid, ContactInfoDto model);


    /// <summary>
    /// Rehber kişisinin iletişim bilgisi siler
    /// </summary>
    /// <param name="id">İletişim bilgisi benzersiz IDsi</param>
    /// <returns></returns>
    Task<bool> DeleteDetailAsync(Guid id);
    /// <summary>
    /// Rehber kişisinin iletişim bilgilerinin de olduğu detay getirir 
    /// </summary>
    /// <param name="uuid">Kişinin bezersiz IDsi</param>
    /// <returns></returns>
    Task<ContactPersonDetailDto> GetDetailAsync(Guid uuid);
}
