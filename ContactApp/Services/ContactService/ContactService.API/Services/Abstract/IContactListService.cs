using ContactService.Core.Concrete;
using ContactService.Core.Dto;

namespace ContactService.API.Services.Abstract;

public interface IContactListService
{
    /// <summary>
    /// Yeni Kayıt ekler
    /// </summary>
    /// <param name="entity">Yeni Kayıt bilgisi</param>
    /// <returns></returns>
    Task<ContactPersonDto> CreateAsync(ContactPersonDto entity);

    /// <summary>
    /// Kaydı siler
    /// </summary>
    /// <param name="id">Silinecek kayıt idsi</param>
    /// <returns></returns>
    Task<ContactPersonDto> DeleteAsync(Guid id);

    /// <summary>
    /// Sayfalamaya uygun arama yapara
    /// </summary>
    /// <param name="model">Arama kriterlerini içeren model</param>
    /// <returns></returns>
    Task<IEnumerable<ContactPersonDto>> FindAsync(ContactFindRequest model);

    /// <summary>
    /// Rehber kaydını getirir
    /// </summary>
    /// <param name="uid">Kaydı getirelecek ID</param>
    /// <returns></returns>
    Task<ContactPersonDto> GetAsync(Guid uid);

    /// <summary>
    /// Detayı ile birlikte Reheber kaydı getirir
    /// </summary>
    /// <param name="uuid"></param>
    /// <returns></returns>
    Task<ContactPersonDetailDto> GetDetailAsync(Guid uuid);

    /// <summary>
    /// Rehberde bir kaydı günceller
    /// </summary>
    /// <param name="entity">Güncellenecek kayıt</param>
    /// <returns></returns>
    Task<ContactPersonDto> UpdateAsync(ContactPersonDto entity);

}
