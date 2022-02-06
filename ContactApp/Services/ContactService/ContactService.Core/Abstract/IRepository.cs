namespace ContactService.Core.Abstract
{
    /// <summary>
    /// Temel veritabanı işlemleri arayüzü
    /// </summary>
    /// <typeparam name="TEntity">Veritabanı modeli</typeparam>
    public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Benzersiz IDsi ile <typeparamref name="TEntity"/>  getirir
        /// </summary>
        /// <param name="uid"><typeparamref name="TEntity"/> benzersiz IDsi</param>
        /// <returns></returns>
        Task<TEntity> GetAsync(Guid uid);

        /// <summary>
        /// <typeparamref name="TEntity"/> tipinde kayıt günceller
        /// </summary>
        /// <param name="entity">Güncellenecek <typeparamref name="TEntity"/> bilgisi</param>
        /// <returns></returns>
        Task<TEntity> UpdateAsync(TEntity entity);

        /// <summary>
        /// <typeparamref name="TEntity"/> tipinde kayıt siler
        /// </summary>
        /// <param name="id">Silinecek kayıdın benzersiz IDsi</param>
        /// <returns></returns>
        Task<bool> DeleteAsync(Guid id);

        /// <summary>
        /// <typeparamref name="TEntity"/> tipinde kayıt ekler
        /// </summary>
        /// <param name="entity">Eklenecek <typeparamref name="TEntity"/> bilgisi</param>
        /// <returns></returns>
        Task<TEntity> CreateAsync(TEntity entity); 

    }
}
